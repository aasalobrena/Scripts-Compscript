#include "../lib/_assign.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"

# DEV
Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _minx, _pyram, _skewb, _sq1],
    AddResults(RoundForEvent(1),
               Persons(CompetingIn())
              )
   )

# Returns AssignmentSet
# Args:
# 1: Number: Number of top competitors per group
# 2: Boolean: Featured
Define("TopPuzzlesSet",
       AssignmentSet(((TOP_SET + PUZZLES) + ToString({2, Boolean})),
                     (IsInTop(_minx-r1, {1, Number}) && In(PAREJAS, ArrayProperty(PUZZLES))),
                     ((GroupNumber() == 1) && (Stage() == BIZKAIA_STAGE)),
                     {2, Boolean}
                    )
      )

FirstRoundAssignGroups(_clock-r1, [], 5, 18, [_444bf-r1], [1])
FirstRoundAssignGroups(_777-r1,   [], 5, 18, [_444bf-r1], [2])
FirstRoundAssignGroups(_sq1-r1,   [], 5, 15, MakeArray<Round>(), [])
FirstRoundAssignGroups(_666-r1,   [], 5, 14, MakeArray<Round>(), [])
FirstRoundAssignGroups(_333bf-r1, [], 5, 18, MakeArray<Round>(), [])
FirstRoundAssignGroups(_555-r1,   [], 5, 20, [_333mbf-r1], [1])
FirstRoundAssignGroups(_minx-r1,
                       [TopPuzzlesSet(5, true),
                        TopPuzzlesSet(19, false),
                        AssignmentSet(PUZZLES,
                                      In(PAREJAS, ArrayProperty(PUZZLES)),
                                      ((GroupNumber() == 1) && Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM])))
                                     )
                       ],
                       5, 19, [_333mbf-r1], [2]
                      )
FirstRoundAssignGroups(_pyram-r1,
                       [AssignmentSet("mbf",
                                      (InTeam([SIDE_TEAM]) || InDelegateCluster([1])),
                                      ((Stage() == ARABA_STAGE) && (GroupNumber() == 3))
                                     ),
                        AssignmentSet("aratz",
                                      (WcaId() == "2022LARR02"),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       5, 22, MakeArray<Round>(), []
                      )
FirstRoundAssignGroups(_444-r1,   [], 5, 16, [_333mbf-r1], [1, 2])
FirstRoundAssignGroups(_222-r1,   [], 5, 19, [_333mbf-r1], [3, 4])
FirstRoundAssignGroups(_skewb-r1, [], 5, 20, [_555bf-r1],  [1, 2])
FirstRoundAssignGroups(_333-r1,
                       [AssignmentSet("zachary",
                                      (WcaId() == "2017MILL04"),
                                      (Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM])) && (GroupNumber() == 1))
                                     )
                       ],
                       5, 21, [_555bf-r1], [4]
                      )
FirstRoundAssignGroups(_333oh-r1,   [], 5, 19, MakeArray<Round>(), [])
