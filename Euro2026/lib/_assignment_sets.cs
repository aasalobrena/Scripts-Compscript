#include "_constants.cs"
#include "_eligible_scramblers.cs"

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
                     [Tuple(2026-07-16, [Tuple(1, GREEN), Tuple(3, ORANGE), Tuple(2, BLUE), Tuple(4, YELLOW), Tuple(5, RED)]),
                      Tuple(2026-07-17, [Tuple(5, GREEN), Tuple(1, ORANGE), Tuple(4, BLUE), Tuple(2, YELLOW), Tuple(3, RED)]),
                      Tuple(2026-07-18, [Tuple(4, GREEN), Tuple(5, ORANGE), Tuple(1, BLUE), Tuple(3, YELLOW), Tuple(2, RED)]),
                      Tuple(2026-07-19, [Tuple(2, GREEN), Tuple(4, ORANGE), Tuple(3, BLUE), Tuple(1, YELLOW), Tuple(5, RED)])
                     ]
                    )
             )
      )

######################################################################

# Args:
# 1: Date
# 2: Event
Define("StagesSets",
       Flatten(Map([1, 2, 3, 4, 5],
                   [AssignmentSet(("leaders-" + ToString(Arg<Number>())),
                                  (In(StringProperty(TYPE), Leader()) && (NumberProperty(TEAM) == Arg<Number>())),
                                  (Stage() == StagePerDateAndTeam({1, Date}, Arg<Number>()))
                                 ),
                    AssignmentSet(("scramblers-" + ToString(Arg<Number>())),
                                  (CanScramble({2, Event}) && (NumberProperty(TEAM) == Arg<Number>())),
                                  (Stage() == StagePerDateAndTeam({1, Date}, Arg<Number>()))
                                 ),
                    AssignmentSet(("volunteers-" + ToString(Arg<Number>())),
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
# 2: Number of top competitors per wave
Define("TopSet",
       AssignmentSet("top",
                     (Seed({1, Round}, Arg<Person>()) <= ({2, Number} * (Length(Groups({1, Round})) / 5))),
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
# 2: Date
# 3: Number of top competitors per wave
Define("NormalRoundAssignmentSets",
       Concat(StagesSets({2, Date}, EventForRound({1, Round})),
              [DataSet(),
               TopSet({1, Round}, {3, Number}),
               EveryoneSet()
              ]
             )
      )

# Args:
# 1: Round
Define("SemifinalsAssignmentSets",
       [AssignmentSet(ORANGE,
                      (Seed({1, Round}, Arg<Person>()) <= 25),
                      (Stage() == ORANGE)
                     ),
        AssignmentSet(GREEN,
                      (Seed({1, Round}, Arg<Person>()) <= 50),
                      (Stage() == GREEN)
                     ),
        AssignmentSet(BLUE,
                      (Seed({1, Round}, Arg<Person>()) <= 75),
                      (Stage() == BLUE)
                     ),
        AssignmentSet(RED,
                      (Seed({1, Round}, Arg<Person>()) <= 100),
                      (Stage() == RED)
                     ),
        AssignmentSet(YELLOW,
                      (Seed({1, Round}, Arg<Person>()) <= 125),
                      (Stage() == YELLOW)
                     )
       ]
      )

# Args:
# 1: Round
Define("FinalsAssignmentSets",
       [AssignmentSet(ORANGE,
                      In(Country(), ["AL", "AD", "AM", "AT", "AZ", "BY", "BE", "BA", "BG", "HR", "CY", "CZ", "DK", "EE", "FI", "FR", "GE", "DE", "GR", "HU", "IS", "IE", "IL", "IT", "XK", "LV", "LI", "LT", "LU", "MT", "MD", "MC", "ME", "NL", "MK", "NO", "PL", "PT", "RO", "RU", "SM", "RS", "SK", "SI", "ES", "SE", "CH", "TR", "UA", "GB", "VA"]),
                      (Stage() == ORANGE)
                     ),
        AssignmentSet(BLUE,
                      true,
                      (Stage() == BLUE)
                     )
       ]
      )