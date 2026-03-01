#include "_constants.cs"
#include "_assignment_sets.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "_unavailabilities.cs"

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
# 2: Number of judges
# 3: Number of runners
# 4: Number of scramblers
Define("AssignVolunteers",
       AssignStaff({1, Round},
                   true,
                   Persons(true),
                   [Judges({2, Number}),
                    Runners({3, Number}),
                    Scramblers({4, Number}, EventForRound({1, Round})),
                    Delegates()
                   ],
                   VolunteerScorers(EventForRound({1, Round})),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )