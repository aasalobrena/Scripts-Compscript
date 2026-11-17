#include "_assignment_sets.cs"
#include "_constants.cs"
#include "_helpers.cs"

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
                           [TopSideSet({5, Array<Round>}, {6, Array<Number>}, {1, Round}, {3, Number}, true),
                            TopSideSet({5, Array<Round>}, {6, Array<Number>}, {1, Round}, {4, Number}, false),
                            SideSet({5, Array<Round>}, {6, Array<Number>}, ARABA_STAGE),
                            SideSet({5, Array<Round>}, {6, Array<Number>}, GIPUZKOA_STAGE),
                            TopSet({1, Round}, {3, Number}, true),
                            TopSet({1, Round}, {4, Number}, false),
                            AssignmentSet(CORE_SET,
                                          InTeam([CORE_TEAM]),
                                          (Stage() == GIPUZKOA_STAGE)
                                         )
                           ],
                           If((StagesPerRound({1, Round}) == 3),
                              [DelegatesSet(RoundDate({1, Round}), [1, 2]),
                               DelegatesSet(RoundDate({1, Round}), [3]),
                               DelegatesSet(RoundDate({1, Round}), [4])
                              ],
                              [DelegatesSet(RoundDate({1, Round}), [5]),
                               DelegatesSet(RoundDate({1, Round}), [6])
                              ]
                             ),
                           [AssignmentSet(AES_SET,
                                          InTeam([AES_TEAM]),
                                          (Stage() == GIPUZKOA_STAGE)
                                         ),
                            AssignmentSet(DATA_SET,
                                          InTeam([DATA_TEAM]),
                                          (Stage() == GIPUZKOA_STAGE)
                                         ),
                            StreamingSet(ARABA_STAGE),
                            StreamingSet(GIPUZKOA_STAGE),
                            EveryoneSet()
                           ]
                          ),
                    [], []
                   )
      )

# Returns GroupAssignmentResult
# Args:
# 1: Round: Round to assign
# 2: Array<AssignmentSet>: Extra Assignment Sets
# 3: Number: Number of featured competitors per group
# 4: Number: Number of top competitors per group
# 5: Array<Round>: Side Round
# 6: Array<Number>: Groups for siders to compete
Define("FirstRoundAssignGroups2",
       AssignGroups({1, Round},
                    Concat({2, Array<AssignmentSet>},
                           [TopSideSet({5, Array<Round>}, {6, Array<Number>}, {1, Round}, {3, Number}, true),
                            TopSideSet({5, Array<Round>}, {6, Array<Number>}, {1, Round}, {4, Number}, false),
                            SideSet({5, Array<Round>}, {6, Array<Number>}, ARABA_STAGE),
                            SideSet({5, Array<Round>}, {6, Array<Number>}, GIPUZKOA_STAGE),
                            TopSet({1, Round}, {3, Number}, true),
                            TopSet({1, Round}, {4, Number}, false),
                            AssignmentSet(CORE_SET,
                                          InTeam([CORE_TEAM]),
                                          (Stage() == GIPUZKOA_STAGE)
                                         )
                           ],
                           If((StagesPerRound({1, Round}) == 3),
                              [DelegatesSet(RoundDate({1, Round}), [1, 2]),
                               DelegatesSet(RoundDate({1, Round}), [3]),
                               DelegatesSet(RoundDate({1, Round}), [4])
                              ],
                              [DelegatesSet(RoundDate({1, Round}), [5]),
                               DelegatesSet(RoundDate({1, Round}), [6])
                              ]
                             )
                          ),
                    [], []
                   )
      )


# Returns GroupAssignmentResult
# Args:
# 1: Round
Define("SecondRoundAssignGroups",
       AssignGroups({1, Round},
                    [AssignmentSet(BIZKAIA_STAGE,
                                   (Seed({1, Round}) <= 25),
                                   ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 2))
                                  ),
                     AssignmentSet(GIPUZKOA_STAGE,
                                   (Seed({1, Round}) <= 50),
                                   ((Stage() == GIPUZKOA_STAGE) && (GroupNumber() == 2))
                                  ),
                     AssignmentSet(ARABA_STAGE,
                                   (Seed({1, Round}) <= 75),
                                   ((Stage() == ARABA_STAGE) && (GroupNumber() == 2))
                                  ),
                     AssignmentSet(BIZKAIA_STAGE,
                                   (Seed({1, Round}) <= 100),
                                   ((Stage() == BIZKAIA_STAGE) && (GroupNumber() == 1))
                                  ),
                     AssignmentSet(GIPUZKOA_STAGE,
                                   (Seed({1, Round}) <= 125),
                                   ((Stage() == GIPUZKOA_STAGE) && (GroupNumber() == 1))
                                  ),
                     AssignmentSet(ARABA_STAGE,
                                   true,
                                   ((Stage() == ARABA_STAGE) && (GroupNumber() == 1))
                                  )
                    ]
                   )
      )

# Returns Array<Tuple<Number, Number>>
Define("SeedToStation",
       [Tuple(1, 4),
        Tuple(2, 5),
        Tuple(3, 3),
        Tuple(4, 6),
        Tuple(5, 2),
        Tuple(6, 7),
        Tuple(7, 1),
        Tuple(8, 8),
        Tuple(9, 11),
        Tuple(10, 12),
        Tuple(11, 10),
        Tuple(12, 13),
        Tuple(13, 9),
        Tuple(14, 14)
       ]
      )

# Returns GroupAssignmentResult
# Args:
# 1: Round
Define("FinalAssignGroups",
       AssignGroups({1, Round},
                    [AssignmentSet(BIZKAIA_STAGE,
                                   (FinalsSeed({1, Round}) <= 14),
                                   (Stage() == BIZKAIA_STAGE)
                                  ),
                     AssignmentSet(GIPUZKOA_STAGE,
                                   true,
                                   (Stage() == GIPUZKOA_STAGE)
                                  )
                    ],
                    stationRules=[StationAssignmentRule((Stage() == BIZKAIA_STAGE),
                                                         "ascending",
                                                         Switch(FinalsSeed({1, Round}), SeedToStation())
                                                       ),
                                  StationAssignmentRule((Stage() == GIPUZKOA_STAGE),
                                                        "ascending",
                                                        FinalsSeed({1, Round})
                                                       )
                                 ]
                   )
      )
