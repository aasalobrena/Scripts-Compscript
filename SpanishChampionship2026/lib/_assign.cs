#include "_constants.cs"
#include "_assignment_sets.cs"

# Returns GroupAssignmentResult
# Args:
# 1: Round: Round to assign
# 2: Array<AssignmentSet>: Extra Assignment Sets
# 3: Number: Number of featured competitors per group
# 4: Number: Number of top competitors per group
# 5: Array<Round>: Side Round
# 6: Array<Number>: Groups for siders to compete
Define("FirstRoundAssignGroups",
       AssignGroups({1, Round},
                    Concat({2, Array<AssignmentSet>},
                           FirstRoundAssignmentSets({1, Round},
                                                    {3, Number},
                                                    {4, Number},
                                                    {5, Array<Round>},
                                                    {6, Array<Number>}
                                                   )
                          ),
                    [], []
                   )
      )
