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