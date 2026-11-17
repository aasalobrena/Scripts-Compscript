#include "_constants.cs"
#include "_helpers.cs"
#include "_jobs.cs"
#include "_unavailabilities.cs"

# Returns Array<Person>
Define("Volunteers", Persons(Not(Or(InTeam([CORE_TEAM, AES_TEAM, STREAMING_TEAM, ACCESS_TEAM, DOCTOR_TEAM, OTRO_TEAM]),
                                    IsPossibleNoShow(),
                                    IsNull(WcaId()),
                                    Not(Registered())
                                   )
                                )
                            )
      )

# Returns Array<Tuple<Event, Number>>
Define("ScrambleSpeedWeight",
       [Tuple(_333,   3),
        Tuple(_222,   3),
        Tuple(_444,   5),
        Tuple(_555,   5),
        Tuple(_666,   8),
        Tuple(_777,   8),
        Tuple(_sq1,   5),
        Tuple(_clock, 5),
        Tuple(_pyram, 3),
        Tuple(_minx,  8),
        Tuple(_skewb, 3),
        Tuple(_333bf, 1),
        Tuple(_333oh, 1)
       ]
      )

# Returns Array<AssignmentScorer>
# Args:
# 1: Round
Define("Scorers",
       [PersonPropertyScorer(Or(CompetingInRound({1, Round}),
                                InTeam([STAGE_TEAM, SIDE_TEAM, DATA_TEAM, DELEGATE_TEAM])
                               ),
                             100000
                            ),
        PersonPropertyScorer(Or(CompetingIn(EventForRound({1, Round})),
                                InTeam([STAGE_TEAM, SIDE_TEAM, DATA_TEAM, DELEGATE_TEAM])
                               ),
                             10000
                            ),
        PersonPropertyScorer(Or(And(((Age() >= 14) && (Age() <= 25)),
                                    (Length(Filter([_clock, _777, _sq1, _666, _333bf, _555, _minx],
                                                   CompetingIn(Arg<Person>())
                                                  )
                                           ) > 0)
                                   ),
                                InTeam([STAGE_TEAM, SIDE_TEAM, DATA_TEAM, DELEGATE_TEAM])
                               ),
                             1000
                            ),
        PersonPropertyScorer(InTeam([STAGE_TEAM, SIDE_TEAM]), 75),
        JobCountScorer(-50),
        PriorAssignmentScorer(-5, -1, Midnight(RoundDate({1, Round}))),
        PriorAssignmentScorer(-2, 0, 2026-12-05T00:00),
        SameJobScorer(60, -5, 4, StandardJobs()),
        ConsecutiveJobScorer(60, -100, 0,
                             jobs=StandardJobs(),
                             personFilter=InTeam([STAGE_TEAM, SIDE_TEAM])
                            ),
        ConsecutiveJobScorer(90, -3, 0,
                             jobs=StandardJobs(),
                             personFilter=Not(InTeam([STAGE_TEAM, SIDE_TEAM]))
                            ),
        SolvingSpeedScorer(ScramblingEvent(EventForRound({1, Round})),
                           ScrambleLimitForEvent(EventForRound({1, Round})),
                           Switch(EventForRound({1, Round}), ScrambleSpeedWeight()),
                           [SCRAMBLER]
                          ),
        ComputedWeightScorer(If(InTeam([STAGE_TEAM, SIDE_TEAM]),
                                NumberProperty(WEIGHT_JUDGE),
                                0),
                             [JUDGE]
                            ),
        ComputedWeightScorer(If(InTeam([STAGE_TEAM, SIDE_TEAM]),
                                NumberProperty(WEIGHT_RUNNER),
                                0),
                             [RUNNER]
                            ),
        ComputedWeightScorer(If(InTeam([STAGE_TEAM, SIDE_TEAM]),
                                NumberProperty(WEIGHT_SCRAMBLER),
                                0),
                             [SCRAMBLER]
                            )
       ]
      )

# Returns StaffAssignmentResult
# Args:
# 1: Round
Define("AllStagesAssignStaff",
       AssignStaff({1, Round},
                   true,
                   Volunteers(),
                   [JudgeJob(16),
                    RunnerJob(3),
                    ScramblerJob(4, EventForRound({1, Round})),
                    DelegateJob(1, BIZKAIA_STAGE, {1, Round}),
                    DelegateJob(1, GIPUZKOA_STAGE, {1, Round}),
                    DelegateJob(1, ARABA_STAGE, {1, Round}),
                    DataentryJob(1, BIZKAIA_STAGE),
                    DataentryJob(2, MAIN_ROOM)
                   ],
                   Concat(Scorers({1, Round}),
                          [ConsecutiveJobScorer(30, -80, 0,
                                                jobs=[SCRAMBLER],
                                                personFilter=InTeam([STAGE_TEAM, SIDE_TEAM])
                                               ),
                           ConsecutiveJobScorer(30, -5, 0,
                                                jobs=[SCRAMBLER],
                                                personFilter=Not(InTeam([STAGE_TEAM, SIDE_TEAM]))
                                               ),
                           SolvingSpeedScorer(ScramblingEvent(EventForRound({1, Round})),
                                              ScrambleLimitForEvent(EventForRound({1, Round})),
                                              Switch(EventForRound({1, Round}), ScrambleSpeedWeight()),
                                              [SCRAMBLER]
                                             ),
                           FollowingGroupScorer(-50, maxMinutes=10)
                          ]
                         ),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )

# Returns Array<AssignmentScorer>
# Args:
# 1: Round
Define("FinalScorers",
       Concat(Scorers({1, Round}),
             [FollowingGroupScorer(-500, maxMinutes=10)]
             )
      )

# Returns StaffAssignmentResult
# Args:
# 1: Round
# 2: Number: Number of judges in GIPUZKOA_STAGE
Define("FinalAssignStaff",
       [AssignStaff({1, Round},
                    (Stage() == BIZKAIA_STAGE),
                    Volunteers(EventForRound({1, Round})),
                    [JudgeJob(15),
                     RunnerJob(3),
                     ScramblerJob(3, EventForRound({1, Round})),
                     CheckerJob(2, EventForRound({1, Round})),
                     DelegateJob(3, BIZKAIA_STAGE, {1, Round})
                    ],
                    FinalScorers({1, Round}),
                    unavailable=Unavailable(Arg<Person>())
                   ),
        AssignStaff({1, Round},
                    (Stage() == GIPUZKOA_STAGE),
                    Volunteers(EventForRound({1, Round})),
                    [JudgeJob({2, Number}),
                     RunnerJob(3),
                     ScramblerJob(2, EventForRound({1, Round})),
                     CheckerJob(1, EventForRound({1, Round})),
                     DelegateJob(2, GIPUZKOA_STAGE, {1, Round})
                    ],
                    FinalScorers({1, Round}),
                    unavailable=Unavailable(Arg<Person>())
                   )
       ]
      )
