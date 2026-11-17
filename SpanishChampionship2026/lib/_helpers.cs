#include "_constants.cs"

# Returns Boolean(Person)
# Args:
# 1: Array<String>: Team
Define("InTeam", In(StringProperty(TEAM), {1, Array<String>}))

# Returns Array<Person>
# Args:
# 1: Array<String>: Team
Define("Team", Persons(InTeam({1, Array<String>})))

# Returns Boolean(Person)
# Args:
# 1: Array<Number>: Delegate Cluster
Define("InDelegateCluster", (In(NumberProperty(DELEGATE_CLUSTER),
                                {1, Array<Number>}
                               ) ||
                             In(NumberProperty(DELEGATE_CLUSTER_EXTRA),
                                {1, Array<Number>}
                               )
                            )
      )

# Returns Array<Person>
# Args:
# 1: Array<String>: Team
# 2: Array<Number>: Delegate Cluster
Define("TeamWithDelegateCluster", Persons((InTeam({1, Array<String>}) || InDelegateCluster({2, Array<Number>}))))

# Returns Array<Tuple<Event, AttemptResult>>
Define("ScrambleLimits",
       [Tuple(_333, 20s),
        Tuple(_222, 8s),
        Tuple(_444, 1:00s),
        Tuple(_555, 1:30s),
        Tuple(_666, 2:45s),
        Tuple(_777, 5:00s),
        Tuple(_clock, 10s),
        Tuple(_minx, 1:30s),
        Tuple(_pyram, 8s),
        Tuple(_skewb, 8s),
        Tuple(_sq1, 20s)
       ]
      )

# Returns Array<Tuple<Event, Event>>
Define("EventsToScramblingEvents",
       [Tuple(_333, _333),
        Tuple(_222, _222),
        Tuple(_444, _444),
        Tuple(_555, _555),
        Tuple(_666, _666),
        Tuple(_777, _777),
        Tuple(_333bf, _333),
        Tuple(_333oh, _333),
        Tuple(_clock, _clock),
        Tuple(_minx, _minx),
        Tuple(_pyram, _pyram),
        Tuple(_skewb, _skewb),
        Tuple(_sq1, _sq1),
        Tuple(_444bf, _444),
        Tuple(_555bf, _555)
       ]
      )

# Returns Event
# Args:
# 1: Event
Define("ScramblingEvent",
       Switch({1, Event},
              EventsToScramblingEvents()
             )
      )

# Returns AttemptResult
# Args:
# 1: Event
Define("ScrambleLimitForEvent",
       Switch(ScramblingEvent({1, Event}),
              ScrambleLimits()
             )
      )

# Returns Boolean(Person)
# Args:
# 1: Event
Define("CanScramble",
       And((PersonalBest(ScramblingEvent({1, Event})) <
            ScrambleLimitForEvent({1, Event})
           ),
           (NumberProperty(WEIGHT_SCRAMBLER) != -1),
           Not(InTeam([DELEGATE_TEAM, DATA_TEAM]))
          )
      )
# Returns Number(Person)
# Args:
# 1: Round
Define("Seed",
       If((RoundNumber({1, Round}) == 1),
          PsychSheetPosition(EventForRound({1, Round})),
          RoundPosition(PreviousRound({1, Round}))
         )
      )

# Returns String
# Args:
# 1: Date
# 2: Number: Delegate cluster
Define("DelegateStage",
       Switch({2, Number},
              Switch({1, Date},
                     [Tuple(2026-12-05,
                            [Tuple(1, ARABA_STAGE),
                             Tuple(2, ARABA_STAGE),
                             Tuple(3, BIZKAIA_STAGE),
                             Tuple(4, GIPUZKOA_STAGE),
                             Tuple(5, GIPUZKOA_STAGE),
                             Tuple(6, BIZKAIA_STAGE)
                            ]
                           ),
                      Tuple(2026-12-06,
                            [Tuple(1, GIPUZKOA_STAGE),
                             Tuple(2, GIPUZKOA_STAGE),
                             Tuple(3, ARABA_STAGE),
                             Tuple(4, BIZKAIA_STAGE),
                             Tuple(5, BIZKAIA_STAGE),
                             Tuple(6, GIPUZKOA_STAGE)
                            ]
                           ),
                      Tuple(2026-12-07,
                            [Tuple(1, BIZKAIA_STAGE),
                             Tuple(2, BIZKAIA_STAGE),
                             Tuple(3, GIPUZKOA_STAGE),
                             Tuple(4, ARABA_STAGE)
                            ]
                           )
                     ]
                    )
             )
      )

# Returns Date
# Args:
# 1: Round
Define("RoundDate",
       Date(At(Groups({1, Round}),
               0
              )
           )
      )

# Returns Number
# Args:
# 1: Round
Define("RoundWaves",
       Switch({1, Round},
              [Tuple(_333-r1, 4),   Tuple(_333-r2, 3),   Tuple(_333-r3, 1), Tuple(_333-r4, 8),
               Tuple(_222-r1, 4),   Tuple(_222-r2, 2),   Tuple(_222-r3, 1),
               Tuple(_444-r1, 4),   Tuple(_444-r2, 2),   Tuple(_444-r3, 1),
               Tuple(_555-r1, 2),   Tuple(_555-r2, 1),
               Tuple(_666-r1, 2),   Tuple(_666-r2, 1),
               Tuple(_777-r1, 2),   Tuple(_777-r2, 1),
               Tuple(_333bf-r1, 2), Tuple(_333bf-r2, 1), Tuple(_333bf-r3, 1),
               Tuple(_333oh-r1, 3), Tuple(_333oh-r2, 1), Tuple(_333oh-r3, 1),
               Tuple(_clock-r1, 2), Tuple(_clock-r2, 1),
               Tuple(_minx-r1, 2),  Tuple(_minx-r2, 1),
               Tuple(_pyram-r1, 3), Tuple(_pyram-r2, 2), Tuple(_pyram-r3, 1),
               Tuple(_skewb-r1, 3), Tuple(_skewb-r2, 2), Tuple(_skewb-r3, 1),
               Tuple(_sq1-r1, 2),   Tuple(_sq1-r2, 1),
               Tuple(_444bf-r1, 1),
               Tuple(_555bf-r1, 1),
               Tuple(_333mbf-r1, 1)
              ]
             )
      )

# Returns Boolean(Person)
# Args:
# 1: Round
# 2: Number: Number of top competitors per group
Define("IsInTop",
       (Seed({1, Round}) <= ({2, Number} * RoundWaves({1, Round})))
      )

# Returns Number
# Args:
# 1: Round
Define("StagesPerRound",
       ((Length(Groups({1, Round})) / RoundWaves({1, Round})) - 1)
      )

# Returns Number(Person)
# Args:
# 1: Round
Define("FinalsSeed",
       (Index(Sort<Person, Number>(Persons(CompetingInRound({1, Round})),
                                   If((Country() == "ES"), 0, 1),
                                   Seed({1, Round})
                                  )
             ) + 1)
      )

# Returns Boolean(Person)
# Args:
# 1: String: Puzzles Event
Define("CompetingInPuzzles",
       In({1, String},
          ArrayProperty(PUZZLES)
         )
      )
