#include "_assignment_sets.cs"
#include "_constants.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "_unavailabilities.cs"

# Args:
# 1: Round
# 2: Date
# 3: Number of top competitors per wave
# 4: Custom assignment sets
Define("AssignGroupsR1",
       AssignGroups({1, Round},
                    Concat({4, Array<AssignmentSet>},
                           NormalRoundAssignmentSets({1, Round},
                                                     {2, Date},
                                                     {3, Number}
                                                    )
                          ),
                    [],
                    []
                   )
      )

# Args:
# 1: Round
# 2: Date
# 3: Team
# 4: Time result for scrambler scorer
# 5: Weight for scrambler scorer
Define("AssignStaffNormalRound",
       AssignStaff({1, Round},
                   (Stage() == StagePerDateAndTeam({2, Date}, {3, Number})),
                   Persons(And((NumberProperty(TEAM) == {3, Number}),
                               Not(In(Weekday({2, Date}), ArrayProperty(UNAVAILABILITY))),
                               Not(IsPossibleNoShow())
                              )
                          ),
                   NormalRoundJobs({1, Round}),
                   DefaultStaffScorers({1, Round}, {4, AttemptResult}, {5, Number}),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )

# Args:
# 1: Round
# 2: Side property used
Define("AssignStaffSide",
       AssignStaff({1, Round},
                   true,
                   Persons(In({2, String}, ArrayProperty(SIDETASKS))),
                   [Job(JUDGE,
                        Length(Persons((In({2, String}, ArrayProperty(SIDETASKS)) && (StringProperty(TYPE) == SIDE)))),
                        eligibility=(StringProperty(TYPE) == SIDE)
                       ),
                    Job(DELEGATE,
                        Length(Persons((In({2, String}, ArrayProperty(SIDETASKS)) && (StringProperty(TYPE) == SIDELEADER)))),
                        eligibility=(StringProperty(TYPE) == SIDELEADER)
                       )
                   ],
                   []
                  )
      )

# Args:
# 1: Round
Define("AssignGroupsSF",
       AssignGroups({1, Round},
                    SemifinalsAssignmentSets({1, Round}),
                    [],
                    []
                   )
      )

# Args:
# 1: Round
Define("AssignGroupsF",
       AssignGroups({1, Round},
                    FinalsAssignmentSets({1, Round}),
                    [],
                    [StationAssignmentRule(true, "ascending", Seed({1, Round}, Arg<Person>()))]
                   )
      )

# Args:
# 1: Round
# 2: Stage
# 3: Date
# 4: Time result for scrambler scorer
# 5: Number of judges
# 6: Number of runners
# 7: Number of scramblers
# 8: Number of checkers
Define("AssignStaffFinalsAux",
       AssignStaff({1, Round},
                   (Stage() == {2, String}),
                   Persons(And(In(StringProperty(TYPE), CoreVolunteer()),
                               (StringProperty(DELEGATE) != ""),
                               Not(In(Weekday({3, Date}), ArrayProperty(UNAVAILABILITY))),
                               Not(IsPossibleNoShow())
                              )
                          ),
                   DefaultJobs({1, Round}, {5, Number}, {6, Number}, {7, Number}, 0, {8, Number}),
                   FinalsScorers({1, Round}, {4, AttemptResult}),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )

# Args:
# 1: Round
# 2: Date
# 3: Time result for scrambler scorer
# 4: Number of green judges
# 5: Number of green runners
# 6: Number of green scramblers
# 7: Number of checkers
Define("AssignStaffFinals",
       [AssignStaffFinalsAux({1, Round}, ORANGE, {2, Date}, {3, AttemptResult}, 14, 3, 3, {7, Number}),
        AssignStaffFinalsAux({1, Round}, GREEN,  {2, Date}, {3, AttemptResult}, {4, Number}, {5, Number}, {6, Number}, {7, Number})
       ]
      )