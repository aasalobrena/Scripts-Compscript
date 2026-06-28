#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"

# Map([_333fm, _444bf, _555bf, _333mbf], AddResults(RoundForEvent(1, Arg<Event>()), Persons(CompetingIn(Arg<Event>()))))
# Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _minx, _pyram, _skewb, _sq1], AddResults(RoundForEvent(1, Arg<Event>()), Persons(CompetingIn(Arg<Event>()))))

AssignGroups(_333fm-r1,  [EveryoneSet()], attemptNumber=1)
AssignGroups(_333fm-r1,  [EveryoneSet()], attemptNumber=2)
AssignGroups(_333fm-r1,  [EveryoneSet()], attemptNumber=3)
AssignGroups(_444bf-r1,  [EveryoneSet()])
AssignGroups(_555bf-r1,  [EveryoneSet()])
AssignGroups(_333mbf-r1, [EveryoneSet()], attemptNumber=1)
AssignGroups(_333mbf-r1, [EveryoneSet()], attemptNumber=2)

AssignGroupsR1(_333oh-r1, 2026-07-16, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333fm-cvv-" + ToString(Arg<Number>())),
                                        ((CompetingIn(_333fm) || In(FM, ArrayProperty(SIDETASKS))) && (NumberProperty(TEAM) == Arg<Number>())),
                                        ((GroupNumber() < 3) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333fm-c",
                                     CompetingIn(_333fm),
                                     ((GroupNumber() < 3) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     ((StringProperty(TYPE) == BOARD) || In(WcaId(), ["2022HAYL02"])),
                                     (GroupNumber() == 1)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_777-r1, 2026-07-16, 10,
               Map([1, 2, 3, 4, 5],
                   AssignmentSet(("333fm-v-" + ToString(Arg<Number>())),
                                 (In(FM, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                 ((GroupNumber() == 2) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                )
                  )
              )
AssignGroupsR1(_444-r1, 2026-07-16, 10,
               Concat([AssignmentSet("sg", (WcaId() == "2022GILB05"), (GroupNumber() == 6))],
                      Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-l1-" + ToString(Arg<Number>())),
                                                 And((StringProperty(TYPE) == SIDELEADER), In(MBF11, ArrayProperty(SIDETASKS)), (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-l2-" + ToString(Arg<Number>())),
                                                 And((StringProperty(TYPE) == SIDELEADER), In(MBF12, ArrayProperty(SIDETASKS)), (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s1-" + ToString(Arg<Number>())),
                                                 (In(MBF11, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 (In(GroupNumber(), [1, 4]) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s2-" + ToString(Arg<Number>())),
                                                 (In(MBF12, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() < 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-v-" + ToString(Arg<Number>())),
                                                 (In(MBF, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() < 5) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-cv-" + ToString(Arg<Number>())),
                                                 (CompetingIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 (In(GroupNumber(), [3, 4]) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("board-" + ToString(Arg<Number>())),
                                                 (In(WcaId(), ["2014ZAKR01"]) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     CompetingIn(_333mbf),
                                     (In(GroupNumber(), [3, 4]) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     (StringProperty(TYPE) == BOARD),
                                     (GroupNumber() == 4)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_clock-r1, 2026-07-16, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-cvv-" + ToString(Arg<Number>())),
                                                 ((CompetingIn(_333mbf) || In(MBF, ArrayProperty(SIDETASKS))) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("board-" + ToString(Arg<Number>())),
                                                 (In(WcaId(), ["2014ZAKR01"]) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     CompetingIn(_333mbf),
                                     ((GroupNumber() == 4) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     (StringProperty(TYPE) == BOARD),
                                     (GroupNumber() == 3)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_skewb-r1, 2026-07-17, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333fm-cvv-" + ToString(Arg<Number>())),
                                        ((CompetingIn(_333fm) || In(FM, ArrayProperty(SIDETASKS))) && (NumberProperty(TEAM) == Arg<Number>())),
                                        ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333fm-c",
                                     CompetingIn(_333fm),
                                     ((GroupNumber() == 1) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     ((StringProperty(TYPE) == BOARD) || In(WcaId(), ["2016MORA24"])),
                                     (GroupNumber() == 1)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_666-r1, 2026-07-17, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333fm-v-" + ToString(Arg<Number>())),
                                        (In(FM, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                        ((GroupNumber() == 2) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet(BOARD,
                                     (StringProperty(TYPE) == BOARD),
                                     (GroupNumber() == 1)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_333bf-r1, 2026-07-17, 10,
               [AssignmentSet(BOARD,
                              ((StringProperty(TYPE) == BOARD) || In(WcaId(), ["2016WHEA01"])),
                              (GroupNumber() == 2)
                             )
               ]
              )
AssignGroupsR1(_sq1-r1, 2026-07-17, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-cv-" + ToString(Arg<Number>())),
                                                 (CompetingIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s1-" + ToString(Arg<Number>())),
                                                 (In(MBF21, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     CompetingIn(_333mbf),
                                     ((GroupNumber() == 3) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     (StringProperty(TYPE) == BOARD),
                                     (GroupNumber() == 3)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_222-r1, 2026-07-17, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-s1-" + ToString(Arg<Number>())),
                                                 (In(MBF21, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s2-" + ToString(Arg<Number>())),
                                                 (In(MBF22, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-cvv-" + ToString(Arg<Number>())),
                                                 ((CompetingIn(_333mbf) || In(MBF, ArrayProperty(SIDETASKS))) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() < 4) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     CompetingIn(_333mbf),
                                     ((GroupNumber() < 4) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     (StringProperty(TYPE) == BOARD),
                                     (GroupNumber() == 5)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_minx-r1, 2026-07-17, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333mbf-cvv-" + ToString(Arg<Number>())),
                                        ((CompetingIn(_333mbf) || In(MBF, ArrayProperty(SIDETASKS))) && (NumberProperty(TEAM) == Arg<Number>())),
                                        ((GroupNumber() > 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333mbf-c",
                                     CompetingIn(_333mbf),
                                     ((GroupNumber() > 1) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     (StringProperty(TYPE) == BOARD),
                                     (GroupNumber() == 3)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_555-r1, 2026-07-18, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("444bf-cvv-" + ToString(Arg<Number>())),
                                                 ((CompetingIn(_444bf) || In(StringProperty(TYPE), SideVolunteer())) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                ),
                                   AssignmentSet(("board-" + ToString(Arg<Number>())),
                                                 (In(WcaId(), ["2016HOLZ01", "2014MILE01"]) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("444bf-c",
                                     CompetingIn(_444bf),
                                     ((GroupNumber() == 4) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     ((StringProperty(TYPE) == BOARD) || In(WcaId(), ["2021MOSE02"])),
                                     (GroupNumber() == 1)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_pyram-r1, 2026-07-18, 10,
               Concat(Map([1, 2, 3, 4, 5],
                           AssignmentSet(("555bf-cvv-" + ToString(Arg<Number>())),
                                         ((CompetingIn(_555bf) || In(StringProperty(TYPE), SideVolunteer())) && (NumberProperty(TEAM) == Arg<Number>())),
                                         ((GroupNumber() < 3) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                        )
                         ),
                      [AssignmentSet("555bf-c",
                                     CompetingIn(_555bf),
                                     ((GroupNumber() < 3) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     ((StringProperty(TYPE) == BOARD) || In(WcaId(), ["2018FOLD01"])),
                                     (GroupNumber() == 1)
                                    )
                      ]
                     )
              )
AssignGroupsR1(_333-r1, 2026-07-18, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333fm-v-" + ToString(Arg<Number>())),
                                                 (In(FM, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 8) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333fm-cv-" + ToString(Arg<Number>())),
                                                 (CompetingIn(_333fm) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() > 5) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                ),
                                   AssignmentSet(("board-" + ToString(Arg<Number>())),
                                                 (In(WcaId(), ["2014IFRA01", "2015HENN02"]) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333fm-c",
                                     CompetingIn(_333fm),
                                     ((GroupNumber() > 5) && In(Stage(), Hall5Stages()))
                                    ),
                       AssignmentSet(BOARD,
                                     ((StringProperty(TYPE) == BOARD) || In(WcaId(), ["2015JORG01", "2016BEAU03", "2017KELL08"])),
                                     (GroupNumber() == 1)
                                    )
                      ]
                     )
              )