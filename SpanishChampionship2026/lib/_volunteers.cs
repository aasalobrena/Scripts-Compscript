#include "_constants.cs"
#include "_helpers.cs"
#include "_jobs.cs"
#include "_unavailabilities.cs"

# Returns Boolean(Person)
# Args:
# 1: Event
Define("Volunteers", Persons(Or(And(CompetingIn({1, Event}),
                                    Not(IsNull(WcaId())),
                                #    Not(IsPossibleNoShow()),
                                    Not(In(StringProperty(TEAM), AllTeams()))
                                   ),
                                InTeam([DELEGATE_TEAM, STAGE_TEAM, SIDE_TEAM])
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
       [JobCountScorer(-50),
        PriorAssignmentScorer(-5, -1, Midnight(RoundDate({1, Round}))),
        PriorAssignmentScorer(-2, 0, 2026-12-05T00:00),
        SameJobScorer(60, -5, 4, StandardJobs()),
        ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobs()),
        ConsecutiveJobScorer(30, -5, 0, jobs=[SCRAMBLER]),
        SolvingSpeedScorer(ScramblingEvent(EventForRound({1, Round})),
                           ScrambleLimitForEvent(EventForRound({1, Round})),
                           Switch(EventForRound({1, Round}), ScrambleSpeedWeight()),
                           [SCRAMBLER]
                          ),
        FollowingGroupScorer(-50, maxMinutes=10),
        PersonPropertyScorer(InTeam([STAGE_TEAM, SIDE_TEAM]), 75),
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
                            ),
        PersonPropertyScorer(CompetingInRound({1, Round}), 1000),
        PersonPropertyScorer((Stage() == DelegateStage(RoundDate({1, Round}),
                                                       If((StagesPerRound({1, Round}) == 3),
                                                          NumberProperty(DELEGATE_CLUSTER),
                                                          NumberProperty(DELEGATE_CLUSTER_EXTRA)
                                                         )
                                                      )
                             ),
                             10000
                            ),
        ConditionalScorer(CanScramble(EventForRound({1, Round})),
                          true,
                          In<String>([JUDGE, RUNNER]),
                          true,
                          -50
                         )
       ]
      )

# Returns StaffAssignmentResult
# Args:
# 1: Round
Define("AllStagesAssignStaff",
       [AssignStaff({1, Round},
                    (Stage() != MAIN_ROOM),
                    Volunteers(EventForRound({1, Round})),
                    [JudgeJob(16),
                     RunnerJob(3),
                     ScramblerJob(4, EventForRound({1, Round})),
                     DelegateJob(1)
                    ],
                    Scorers({1, Round}),
                    unavailable=Unavailable(Arg<Person>())
                   ),
        AssignStaff({1, Round},
                    (Stage() == MAIN_ROOM),
                    Team([DATA_TEAM]),
                    [DataentryJob(2)],
                    Scorers({1, Round}),
                    unavailable=Unavailable(Arg<Person>())
                   ),
        AssignStaff({1, Round},
                    (Stage() == BIZKAIA_STAGE),
                    Team([DATA_TEAM]),
                    [DataentryJob(1)],
                    Scorers({1, Round}),
                    unavailable=Unavailable(Arg<Person>())
                   )
       ]
      )

# Returns Array<AssignmentScorer>
# Args:
# 1: Round
Define("FinalScorers",
       [JobCountScorer(-50),
        PriorAssignmentScorer(-5, -1, Midnight(RoundDate({1, Round}))),
        PriorAssignmentScorer(-2, 0, 2026-12-05T00:00),
        SameJobScorer(60, -5, 4, StandardJobs()),
        ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobs()),
        SolvingSpeedScorer(ScramblingEvent(EventForRound({1, Round})),
                           ScrambleLimitForEvent(EventForRound({1, Round})),
                           Switch(EventForRound({1, Round}), ScrambleSpeedWeight()),
                           [SCRAMBLER]
                          ),
        FollowingGroupScorer(-500, maxMinutes=10),
        PersonPropertyScorer(InTeam([STAGE_TEAM, SIDE_TEAM]), 10000),
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
# 2: Number: Number of judges in GIPUZKOA_STAGE
Define("FinalAssignStaff",
       [AssignStaff({1, Round},
                    (Stage() == BIZKAIA_STAGE),
                    Volunteers(EventForRound({1, Round})),
                    [JudgeJob(15),
                     RunnerJob(3),
                     ScramblerJob(3, EventForRound({1, Round})),
                     CheckerJob(2, EventForRound({1, Round})),
                     DelegateJob(3)
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
                     DelegateJob(2)
                    ],
                    FinalScorers({1, Round}),
                    unavailable=Unavailable(Arg<Person>())
                   )
       ]
      )
