#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"
#include "../lib/_jobs.cs"
#include "../lib/_unavailabilities.cs"

# DEV
# AddResults(_333-r4, Persons((PsychSheetPosition(_333) <= 23)))

AssignGroups(_333-r4,
             [AssignmentSet(BIZKAIA_STAGE,
                            (Country() == "ES"),
                            (Stage() == BIZKAIA_STAGE)
                           ),
              AssignmentSet(GIPUZKOA_STAGE,
                            true,
                            (Stage() == GIPUZKOA_STAGE)
                           )
             ],
             stationRules=[StationAssignmentRule((Stage() == GIPUZKOA_STAGE),
                                                 "ascending",
                                                 Seed(_333-r4)
                                                )
                          ]
            )

AssignStaff(_333-r4,
            (Stage() == GIPUZKOA_STAGE),
            Team([STAGE_TEAM, SIDE_TEAM, DELEGATE_TEAM]),
            [JudgeJob(x),
             RunnerJob(3),
             ScramblerJob(2, _333),
             CheckerJob(1, _333),
             DelegateJob(2, GIPUZKOA_STAGE, _333-r4)
            ],
            [SolvingSpeedScorer(_333,
                                ScrambleLimitForEvent(_333),
                                Switch(_333, ScrambleSpeedWeight()),
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
                                 ),
             FollowingGroupScorer(-1000, maxMinutes=10)
            ],
            unavailable=Unavailable(Arg<Person>())
           )
