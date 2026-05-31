#include "_constants.cs"

######################################################################
#                              HELPERS
######################################################################

# Args:
# 1: Round
# 2: Person
Define("Seed",
       If((RoundNumber({1, Round}) == 1),
          PsychSheetPosition(EventForRound({1, Round})),
          RoundPosition(PreviousRound({1, Round}), {2, Person})
         )
      )

# Args:
# 1: Date
# 2: Team
Define("StagePerDateAndTeam",
       Switch({2, Number},
              Switch({1, Date},
                     [Tuple(2026-07-16, [Tuple(1, GREEN), Tuple(2, ORANGE), Tuple(3, BLUE), Tuple(4, YELLOW), Tuple(5, RED)]),
                      Tuple(2026-07-17, [Tuple(2, GREEN), Tuple(3, ORANGE), Tuple(4, BLUE), Tuple(5, YELLOW), Tuple(1, RED)]),
                      Tuple(2026-07-18, [Tuple(3, GREEN), Tuple(4, ORANGE), Tuple(5, BLUE), Tuple(1, YELLOW), Tuple(2, RED)]),
                      Tuple(2026-07-19, [Tuple(4, GREEN), Tuple(5, ORANGE), Tuple(1, BLUE), Tuple(2, YELLOW), Tuple(3, RED)])
                     ]
                    )
             )
      )

######################################################################

Define("SGSet",
       AssignmentSet("sg",
                     (WcaId() == "2022GILB05"),
                     ((RoundId(Round()) == "444-r1") && (GroupNumber() == (Length(Groups(_444-r1)) / 5)))
                    )
      )

# Args:
# 1: Side rounds
# 2: Allowed groups in normal round
Define("SideSet",
       AssignmentSet("side",
                     ((Length({1, Array<Round>}) > 0) && ((StringProperty(TYPE) == SIDE) || (Length(Filter({1, Array<Round>}, CompetingInRound())) > 0))),
                     In(GroupNumber(), {2, Array<Number>})
                    )
      )

# Args:
# 1: Date
Define("StagesSets",
       Flatten(Map([1, 2, 3, 4, 5],
                   [AssignmentSet(("leaders" + ToString(Arg<Number>())),
                                  ((StringProperty(TYPE) == LEADER) && (NumberProperty(TEAM) == Arg<Number>())),
                                  (Stage() == StagePerDateAndTeam({1, Date}, Arg<Number>()))
                                 ),
                    AssignmentSet(("volunteers" + ToString(Arg<Number>())),
                                  (NumberProperty(TEAM) == Arg<Number>()),
                                  (Stage() == StagePerDateAndTeam({1, Date}, Arg<Number>()))
                                 )
                   ]
                  )
              )
      )

Define("DataSet",
       AssignmentSet("data",
                     (StringProperty(TYPE) == DATA),
                     In(Stage(), Hall123Stages())
                    )
      )

# Args:
# 1: Round
# 2: Number of featured competitors per wave
Define("FeaturedSet",
       AssignmentSet("featured",
                     (Seed({1, Round}, Arg<Person>()) <= ({2, Number} * (Length(Groups({1, Round})) / 5))),
                     (Stage() == ORANGE),
                     true
                    )
      )

# Args:
# 1: Round
# 2: Number of top competitors per round
Define("TopSet",
       AssignmentSet("top",
                     (Seed({1, Round}, Arg<Person>()) <= {2, Number}),
                     (Stage() == ORANGE),
                     true
                    )
      )

Define("EveryoneSet",
       AssignmentSet("everyone",
                     true,
                     true
                    )
      )

# Args:
# 1: Round
# 2: Simultaneous side room rounds
# 3: Allowed groups for side roomers to compete
# 4: Date
# 5: Number of featured competitors per wave
# 6: Number of top competitors per round
Define("NormalRoundAssignmentSets",
       Concat([SGSet(),
               SideSet({2, Array<Round>}, {3, Array<Number>})
              ],
              StagesSets({4, Date}),
              [DataSet(),
               FeaturedSet({1, Round}, {5, Number}),
               TopSet({1, Round}, {6, Number}),
               EveryoneSet()
              ]
             )
      )