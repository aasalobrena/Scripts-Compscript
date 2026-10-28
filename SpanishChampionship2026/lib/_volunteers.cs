#include "_constants.cs"
#include "_helpers.cs"
#include "_jobs.cs"
#include "_unavailabilities.cs"

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
        PersonPropertyScorer(CompetingInRound({1, Round}), 100),
        PersonPropertyScorer((Stage() == DelegateStage(RoundDate({1, Round}),
                                                       NumberProperty(DELEGATE_CLUSTER)
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
       AssignStaff({1, Round},
                   (Stage() != MAIN_ROOM),
                   Volunteers(EventForRound({1, Round})),
                   [JudgeJob(16),
                    RunnerJob(3),
                    ScramblerJob(4, EventForRound({1, Round})),
                    DelegateJob(1)
                   ],
                   Scorers({1, Round}),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )
