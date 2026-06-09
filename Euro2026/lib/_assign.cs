#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"
#include "../lib/_unavailabilities.cs"

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
Define("AssignStaffR1",
       AssignStaff({1, Round},
                   (Stage() == StagePerDateAndTeam({2, Date}, {3, Number})),
                   Persons(((NumberProperty(TEAM) == {3, Number}) && Not(In(Weekday({2, Date}), ArrayProperty(UNAVAILABILITY))))),
                   NormalRoundJobs({1, Round}),
                   DefaultStaffScorers({1, Round}, {4, AttemptResult}, {5, Number}),
                   unavailable=Unavailable(Arg<Person>())
                  )
      )