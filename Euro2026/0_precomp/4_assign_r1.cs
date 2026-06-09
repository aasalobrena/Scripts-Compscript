#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"

# DEV:
Define("Qualified", Switch({1, Event}, [Tuple(_333fm, 50), Tuple(_444bf, 25), Tuple(_555bf, 25), Tuple(_333mbf, 25)]))
Define("QualifiedIn", (CompetingIn({1, Event}) && (PsychSheetPosition({1, Event}) <= Qualified({1, Event}))))

Map([_333fm, _444bf, _555bf, _333mbf], AddResults(RoundForEvent(1, Arg<Event>()), Persons(QualifiedIn(Arg<Event>()))))
Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _minx, _pyram, _skewb, _sq1], AddResults(RoundForEvent(1, Arg<Event>()), Persons(CompetingIn(Arg<Event>()))))

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
                                        ((QualifiedIn(_333fm) && (NumberProperty(TEAM) == Arg<Number>())) || In(FM, ArrayProperty(SIDETASKS))),
                                        ((GroupNumber() < 3) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333fm-c",
                                     QualifiedIn(_333fm),
                                     ((GroupNumber() < 3) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_777-r1, 2026-07-16, 10,
               Map([1, 2, 3, 4, 5],
                   AssignmentSet(("333fm-v" + ToString(Arg<Number>())),
                                 (In(FM, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                 ((GroupNumber() == 2) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                )
                  )
              )
AssignGroupsR1(_444-r1, 2026-07-16, 10,
               Concat([AssignmentSet("sg", (WcaId() == "2022GILB05"), (GroupNumber() == 6))],
                      Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-l1" + ToString(Arg<Number>())),
                                                 And((StringProperty(TYPE) == SIDELEADER), In(MBF11, ArrayProperty(SIDETASKS)), (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-l2" + ToString(Arg<Number>())),
                                                 And((StringProperty(TYPE) == SIDELEADER), In(MBF12, ArrayProperty(SIDETASKS)), (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s1" + ToString(Arg<Number>())),
                                                 (In(MBF11, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 (In(GroupNumber(), [1, 4]) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s2" + ToString(Arg<Number>())),
                                                 (In(MBF12, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() < 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-v" + ToString(Arg<Number>())),
                                                 (In(MBF, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() < 5) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-cv" + ToString(Arg<Number>())),
                                                 (QualifiedIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 (In(GroupNumber(), [3, 4]) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     QualifiedIn(_333mbf),
                                     (In(GroupNumber(), [3, 4]) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_clock-r1, 2026-07-16, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333mbf-cvv" + ToString(Arg<Number>())),
                                        ((QualifiedIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())) || In(MBF, ArrayProperty(SIDETASKS))),
                                        ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-16, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333mbf-c",
                                     QualifiedIn(_333mbf),
                                     ((GroupNumber() == 4) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_skewb-r1, 2026-07-17, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333fm-cvv" + ToString(Arg<Number>())),
                                        ((QualifiedIn(_333fm) && (NumberProperty(TEAM) == Arg<Number>())) || In(FM, ArrayProperty(SIDETASKS))),
                                        ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333fm-c",
                                     QualifiedIn(_333fm),
                                     ((GroupNumber() == 1) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_666-r1, 2026-07-17, 10,
               Map([1, 2, 3, 4, 5],
                   AssignmentSet(("333fm-v" + ToString(Arg<Number>())),
                                 (In(FM, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                 ((GroupNumber() == 2) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                )
                  )
              )
AssignGroupsR1(_333bf-r1, 2026-07-17, 10, [])
AssignGroupsR1(_sq1-r1, 2026-07-17, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-cv" + ToString(Arg<Number>())),
                                                 (QualifiedIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s1" + ToString(Arg<Number>())),
                                                 (In(MBF21, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     QualifiedIn(_333mbf),
                                     ((GroupNumber() == 3) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_222-r1, 2026-07-17, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333mbf-s1" + ToString(Arg<Number>())),
                                                 (In(MBF21, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 3) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-s2" + ToString(Arg<Number>())),
                                                 (In(MBF22, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333mbf-cvv" + ToString(Arg<Number>())),
                                                 ((QualifiedIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())) || In(MBF, ArrayProperty(SIDETASKS))),
                                                 ((GroupNumber() < 4) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333mbf-c",
                                     QualifiedIn(_333mbf),
                                     ((GroupNumber() < 4) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_minx-r1, 2026-07-17, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("333mbf-cv" + ToString(Arg<Number>())),
                                        ((QualifiedIn(_333mbf) && (NumberProperty(TEAM) == Arg<Number>())) || In(MBF, ArrayProperty(SIDETASKS))),
                                        ((GroupNumber() > 1) && (Stage() == StagePerDateAndTeam(2026-07-17, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("333mbf-c",
                                     QualifiedIn(_333mbf),
                                     ((GroupNumber() > 1) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_555-r1, 2026-07-18, 10,
               Concat(Map([1, 2, 3, 4, 5],
                          AssignmentSet(("444bf-cvv" + ToString(Arg<Number>())),
                                        ((QualifiedIn(_444bf) && (NumberProperty(TEAM) == Arg<Number>())) || In(StringProperty(TYPE), SideVolunteer())),
                                        ((GroupNumber() == 4) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                       )
                         ),
                      [AssignmentSet("444bf-c",
                                     QualifiedIn(_444bf),
                                     ((GroupNumber() == 4) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_pyram-r1, 2026-07-18, 10,
               Concat(Map([1, 2, 3, 4, 5],
                           AssignmentSet(("555bf-cvv" + ToString(Arg<Number>())),
                                         ((QualifiedIn(_555bf) && (NumberProperty(TEAM) == Arg<Number>())) || In(StringProperty(TYPE), SideVolunteer())),
                                         ((GroupNumber() < 3) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                        )
                         ),
                      [AssignmentSet("555bf-c",
                                     QualifiedIn(_555bf),
                                     ((GroupNumber() < 3) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )
AssignGroupsR1(_333-r1, 2026-07-18, 10,
               Concat(Flatten(Map([1, 2, 3, 4, 5],
                                  [AssignmentSet(("333fm-v" + ToString(Arg<Number>())),
                                                 (In(FM, ArrayProperty(SIDETASKS)) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() == 8) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                ),
                                   AssignmentSet(("333fm-cvv" + ToString(Arg<Number>())),
                                                 (QualifiedIn(_333fm) && (NumberProperty(TEAM) == Arg<Number>())),
                                                 ((GroupNumber() > 5) && (Stage() == StagePerDateAndTeam(2026-07-18, Arg<Number>())))
                                                )
                                  ]
                                 )
                             ),
                      [AssignmentSet("333fm-c",
                                     QualifiedIn(_333fm),
                                     ((GroupNumber() > 5) && In(Stage(), Hall5Stages()))
                                    )
                      ]
                     )
              )

ManuallyAssign(Persons((In(FM, ArrayProperty(SIDETASKS)) && (StringProperty(TYPE) == SIDE))),
               _333fm-r1,
               SIDEROOM,
               1,
               STAFFJUDGE
              )
ManuallyAssign(Persons((In(FM, ArrayProperty(SIDETASKS)) && (StringProperty(TYPE) == SIDELEADER))),
               _333fm-r1,
               SIDEROOM,
               1,
               STAFFDELEGATE
              )
ManuallyAssign(Persons((In(MBF, ArrayProperty(SIDETASKS)) && (StringProperty(TYPE) == SIDE))),
               _333mbf-r1,
               SIDEROOM,
               1,
               STAFFJUDGE
              )
ManuallyAssign(Persons((In(MBF, ArrayProperty(SIDETASKS)) && (StringProperty(TYPE) == SIDELEADER))),
               _333mbf-r1,
               SIDEROOM,
               1,
               STAFFDELEGATE
              )

ManuallyAssign(Persons((StringProperty(TYPE) == SIDE)),
               _444bf-r1,
               SIDEROOM,
               1,
               STAFFJUDGE
              )
ManuallyAssign(Persons((StringProperty(TYPE) == SIDELEADER)),
               _444bf-r1,
               SIDEROOM,
               1,
               STAFFDELEGATE
              )
ManuallyAssign(Persons((StringProperty(TYPE) == SIDE)),
               _555bf-r1,
               SIDEROOM,
               1,
               STAFFJUDGE
              )
ManuallyAssign(Persons((StringProperty(TYPE) == SIDELEADER)),
               _555bf-r1,
               SIDEROOM,
               1,
               STAFFDELEGATE
              )

Map([1, 2, 3, 4, 5], AssignStaffR1(_333oh-r1, 2026-07-16, Arg<Number>(),   15s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_777-r1,   2026-07-16, Arg<Number>(), 3:00s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_444-r1,   2026-07-16, Arg<Number>(),   45s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_clock-r1, 2026-07-16, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_skewb-r1, 2026-07-17, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_666-r1,   2026-07-17, Arg<Number>(), 2:50s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_333bf-r1, 2026-07-17, Arg<Number>(),   15s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_sq1-r1,   2026-07-17, Arg<Number>(),   15s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_222-r1,   2026-07-17, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_minx-r1,  2026-07-17, Arg<Number>(),   45s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_555-r1,   2026-07-18, Arg<Number>(), 1:00s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_pyram-r1, 2026-07-18, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_333-r1,   2026-07-18, Arg<Number>(),   15s, 20))