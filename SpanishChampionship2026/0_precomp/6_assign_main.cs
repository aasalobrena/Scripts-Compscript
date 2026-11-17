#include "../lib/_assign.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"

# DEV
# Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _minx, _pyram, _skewb, _sq1],
#     AddResults(RoundForEvent(1),
#                Persons(CompetingIn())
#               )
#    )

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

FirstRoundAssignGroups(_clock-r1,
                       [AssignmentSet("gabriel_r",
                                      In<Person>([2022RODR52]),
                                      (Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM])) && (GroupNumber() == 1))
                                     ),
                        AssignmentSet("sergio_m",
                                      In<Person>([2023FERN54]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 22, [_444bf-r1], [1]
                      )

FirstRoundAssignGroups(_777-r1,
                       [AssignmentSet("elies_q",
                                      In<Person>([2019GARC35]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 22, [_444bf-r1], [2]
                      )

FirstRoundAssignGroups(_sq1-r1,
                       [AssignmentSet("carlos_m",
                                      In<Person>([2010GARC02]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 19, MakeArray<Round>(), []
                      )

FirstRoundAssignGroups(_666-r1,
                       [AssignmentSet("antonio_l, elies_q",
                                      In<Person>([2014LOPE04, 2019GARC35]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 17, MakeArray<Round>(), []
                      )

FirstRoundAssignGroups(_333bf-r1,
                       [AssignmentSet("gabriel_r",
                                      In<Person>([2022RODR52]),
                                      (Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM])) && (GroupNumber() == 2))
                                     ),
                        AssignmentSet("iker_c",
                                      In<Person>([2016RUIZ05]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 22, MakeArray<Round>(), []
                      )

FirstRoundAssignGroups(_555-r1,
                       [AssignmentSet("arian_m",
                                      In<Person>([2020NUNE01]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     ),
                        AssignmentSet("raul_m",
                                      In<Person>([2017REDO02]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1))
                                     ),
                        AssignmentSet("pedro_a",
                                      In<Person>([2018AZEV03]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 2))
                                     )
                       ],
                       4, 24, [_333mbf-r1], [1]
                      )

FirstRoundAssignGroups(_minx-r1,
                       [TopPuzzlesSet(4, true),
                        TopPuzzlesSet(19, false),
                        AssignmentSet(PUZZLES,
                                      In(PAREJAS, ArrayProperty(PUZZLES)),
                                      ((GroupNumber() == 1) && Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM])))
                                     ),
                        AssignmentSet("pablo_a",
                                      In<Person>([2023VELA19]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 25, [_333mbf-r1], [2]
                      )

FirstRoundAssignGroups(_pyram-r1,
                       [AssignmentSet("mbf",
                                      (InTeam([SIDE_TEAM]) || InDelegateCluster([1])),
                                      ((Stage() == ARABA_STAGE) && (GroupNumber() == 3))
                                     ),
                        AssignmentSet("aratz_l",
                                      In<Person>([2022LARR02]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 26, MakeArray<Round>(), []
                      )

FirstRoundAssignGroups(_444-r1,
                       [AssignmentSet("biel_s",
                                      In<Person>([2015GONZ08]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     ),
                        AssignmentSet("raul_m",
                                      In<Person>([2017REDO02]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 3)),
                                      true
                                     ),
                        AssignmentSet("pedro_a",
                                      In<Person>([2018AZEV03]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 4))
                                     )
                       ],
                       4, 20, [_333mbf-r1], [1, 2]
                      )

FirstRoundAssignGroups(_222-r1, [], 4, 23, [_333mbf-r1], [3, 4])

FirstRoundAssignGroups(_skewb-r1,
                       [AssignmentSet("alex_r",
                                      In<Person>([2023LANG03]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 24, [_555bf-r1],  [1, 2]
                      )

FirstRoundAssignGroups(_333-r1,
                       [AssignmentSet("zachary_m",
                                      In<Person>([2017MILL04]),
                                      (Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM])) && (GroupNumber() == 1))
                                     ),
                        AssignmentSet("marisa_r",
                                      In<Person>([2022RUIZ02]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     ),
                        AssignmentSet("raul_m",
                                      In<Person>([2017REDO02]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1))
                                     ),
                        AssignmentSet("jesus_l",
                                      In<Person>([2013GARC08]),
                                      ((Stage() == ARABA_STAGE) && (GroupNumber() == 2))
                                     )
                       ],
                       4, 25, [_555bf-r1], [4]
                      )

FirstRoundAssignGroups(_333oh-r1,
                       [AssignmentSet("mikel_m",
                                      In<Person>([2024ZARR01]),
                                      ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1)),
                                      true
                                     )
                       ],
                       4, 23, MakeArray<Round>(), []
                      )
