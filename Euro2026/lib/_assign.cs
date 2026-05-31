#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"
#include "../lib/_jobs.cs"

# Args:
# 1: Round
# 2: Simultaneous side room rounds
# 3: Allowed groups for side roomers to compete
# 4: Date
# 5: Number of featured competitors per wave
# 6: Number of top competitors per round
Define("AssignGroupsR1",
       AssignGroups({1, Round},
                    NormalRoundAssignmentSets({1, Round},
                                              {2, Array<Round>},
                                              {3, Array<Number>},
                                              {4, Date},
                                              {5, Number},
                                              {6, Number}
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
Define("AssignStaffR1",
       AssignStaff({1, Round},
                   (Stage() == StagePerDateAndTeam({2, Date}, {3, Number})),
                   Persons(((NumberProperty(TEAM) == {3, Number}) && Not(In(Weekday({2, Date}), ArrayProperty(UNAVAILABILITY))))),
                   NormalRoundJobs({1, Round}),
                   DefaultStaffScorers({1, Round}, {4, AttemptResult}, {5, Number})
                  )
      )