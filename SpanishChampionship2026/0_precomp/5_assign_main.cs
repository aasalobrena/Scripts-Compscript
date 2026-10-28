#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"

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

FirstRoundAssignGroups(_clock-r1, [], 5, 20, [_444bf-r1], [1])
FirstRoundAssignGroups(_777-r1,   [], 5, 11, [_444bf-r1], [2])
FirstRoundAssignGroups(_sq1-r1,   [], 5, 15, MakeArray<Round>(), [])
FirstRoundAssignGroups(_666-r1,   [], 5, 13, MakeArray<Round>(), [])
FirstRoundAssignGroups(_333bf-r1, [], 5, 11, MakeArray<Round>(), [])
FirstRoundAssignGroups(_555-r1,   [], 5, 19, [_333mbf-r1], [1])
FirstRoundAssignGroups(_minx-r1,  [], 5, 19, [_333mbf-r1], [2])
FirstRoundAssignGroups(_pyram-r1,
                       [AssignmentSet("mbf",
                                      (InTeam([SIDE_TEAM]) || InDelegateCluster([1])),
                                      ((Stage() == ARABA_STAGE) && (GroupNumber() == 3))
                                     )
                       ],
                       5, 21,
                       MakeArray<Round>(), []
                      )
FirstRoundAssignGroups(_444-r1,   [], 5, 16, [_333mbf-r1], [1, 2])
FirstRoundAssignGroups(_222-r1,   [], 5, 18, [_333mbf-r1], [3, 4])
FirstRoundAssignGroups(_skewb-r1, [], 5, 20, [_555bf-r1],  [1, 2])
FirstRoundAssignGroups(_333-r1,   [], 5, 20, [_555bf-r1],  [4])
