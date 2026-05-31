#include "../lib/_assignment_sets.cs"

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