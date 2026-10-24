#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

FirstRoundAssignGroups(_clock-r1, [], 5, 20, [_444bf-r1], [1, 2])
FirstRoundAssignGroups(_777-r1,   [], 5, 11, [_444bf-r1], [2])
FirstRoundAssignGroups(_sq1-r1,   [], 5, 15, [], [])
FirstRoundAssignGroups(_666-r1,   [], 5, 13, [], [])
FirstRoundAssignGroups(_333bf-r1, [], 5, 11, [], [])
FirstRoundAssignGroups(_555-r1,   [], 5, 19, [], [])
FirstRoundAssignGroups(_minx-r1,  [], 5, 19, [], [])
FirstRoundAssignGroups(_pyram-r1,
                       [AssignmentSet("mbf",
                                      (InTeam(SIDE_TEAM) || InDelegateCluster([1])),
                                      ((Stage() == ARABA_STAGE) && (GroupNumber() == 3))
                                     )
                       ],
                       5, 21,
                       [], []
                      )
FirstRoundAssignGroups(_444-r1,   [], 5, 16, [_333mbf-r1], [1, 2])
FirstRoundAssignGroups(_222-r1,   [], 5, 18, [_333mbf-r1], [3, 4])
FirstRoundAssignGroups(_skewb-r1, [], 5, 20, [_555bf-r1],  [1, 2])
FirstRoundAssignGroups(_333-r1,   [], 5, 20, [_555bf-r1],  [4])
