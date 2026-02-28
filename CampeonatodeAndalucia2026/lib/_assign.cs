#include "_constants.cs"
#include "_assignment_sets.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "_unavailabilities.cs"

# Args:
# 1: Round
Define("ScramblersPerRound",
       Switch({1, Round},
              [Tuple(_333-r1, 4),
               Tuple(_333-r2, 3),
               Tuple(_333-r3, 3),
               Tuple(_222-r1, 4),
               Tuple(_222-r2, 3),
               Tuple(_444-r1, 4),
               Tuple(_444-r2, 3),
               Tuple(_555-r1, 4),
               Tuple(_555-r2, 3),
               Tuple(_666-r1, 3),
               Tuple(_777-r1, 3),
               Tuple(_333bf-r1, 3),
               Tuple(_333bf-r2, 3),
               Tuple(_333oh-r1, 3),
               Tuple(_333oh-r2, 3),
               Tuple(_clock-r1, 3),
               Tuple(_clock-r2, 3),
               Tuple(_minx-r1, 3),
               Tuple(_minx-r2, 3),
               Tuple(_pyram-r1, 4),
               Tuple(_pyram-r2, 3),
               Tuple(_skewb-r1, 3),
               Tuple(_skewb-r2, 3),
               Tuple(_sq1-r1, 3),
               Tuple(_sq1-r2, 3)
              ],
              0
             )
      )

# Args:
# 1: Round
Define("AssignWaitingGroups",
       AssignGroups({1, Round},
                    NormalRoundAssignmentSets({1, Round}), [], []
                   )
      )

# Args:
# 1: Round
Define("AssignFixedGroups",
       AssignGroups({1, Round},
                    NormalRoundAssignmentSets({1, Round}),
                    [],
                    [StationAssignmentRule(true,
                                           "ascending",
                                           If((RoundNumber({1, Round}) == 1),
                                              PsychSheetPosition(EventForRound({1, Round})),
                                              RoundPosition(PreviousRound({1, Round}))
                                             )
                                          )
                    ]
                   )
      )

# Args:
# 1: Round
# 2: Date of the round
# 3: Number of judges
# 4: Number of runners
# 5: Number of scramblers
Define("AssignVolunteers",
       AssignStaff({1, Round},
                   true,
                   Persons(true),
                   [Judges({3, Number}),
                    Runners({4, Number}),
                    Scramblers({5, Number}, EventForRound({1, Round})),
                    Delegates()
                   ],
                   VolunteerScorers(EventForRound({1, Round}), {2, Date}),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )