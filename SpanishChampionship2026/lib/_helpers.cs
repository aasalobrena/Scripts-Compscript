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
Define("InDelegateCluster", In(NumberProperty(DELEGATE_CLUSTER), {1, Array<Number>}))

# Returns Array<Person>
# Args:
# 1: Array<Number>: Delegate Cluster
Define("DelegateCluster", Persons(InDelegateCluster({1, Array<Number>})))

# Returns Array<Person>
# Args:
# 1: Array<String>: Team
# 2: Array<Number>: Delegate Cluster
Define("TeamWithDelegateCluster", Persons((InTeam({1, Array<String>}) || InDelegateCluster({2, Array<Number>}))))

# Returns Boolean(Person)
# Args:
# 1: Event
Define("CanVolunteer",
       Or(And(CompetingIn({1, Event}),
              Not(IsNull(WcaId())),
              Not(HasProperty(TEAM))
             ),
          InTeam([STAGE_TEAM, SIDE_TEAM])
         )
      )

# Returns Boolean(Person)
# Args:
# 1: Event
Define("Volunteers", Persons(CanVolunteer({1, Event})))

# Returns Boolean(Person)
Define("CanJudge", true) # dummy

# Returns Boolean(Person)
Define("CanRun", true) # dummy

# Returns Boolean(Person)
# Args:
# 1: Event
Define("CanScramble", true) # dummy

# Returns Boolean(Person)
Define("CanDelegate", (NumberProperty(DELEGATE_CLUSTER) > 0))

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
                     [Tuple(2026-12-05, [Tuple(1, BIZKAIA_STAGE),  Tuple(2, BIZKAIA_STAGE),  Tuple(3, GIPUZKOA_STAGE), Tuple(4, ARABA_STAGE)]),
                      Tuple(2026-12-06, [Tuple(1, GIPUZKOA_STAGE), Tuple(2, GIPUZKOA_STAGE), Tuple(3, ARABA_STAGE),    Tuple(4, BIZKAIA_STAGE)]),
                      Tuple(2026-12-07, [Tuple(1, ARABA_STAGE),    Tuple(2, ARABA_STAGE),    Tuple(3, BIZKAIA_STAGE),  Tuple(4, GIPUZKOA_STAGE)])
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
               Tuple(_333oh-r1, 4), Tuple(_333oh-r2, 1), Tuple(_333oh-r3, 1),
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

# Returns Number
# Args:
# 1: Round
# 2: Number: Number of competitors per group
Define("NumberPerGroupToPerRound",
       ({2, Number} * (Length(Groups({1, Round})) / RoundWaves({1, Round})))
      )

# Returns Boolean(Person)
# Args:
# 1: Round
# 2: Number: Number of top competitors per group
Define("IsInTop",
       (Seed({1, Round}) <= NumberPerGroupToPerRound({1, Round}, {2, Number}))
      )

# Returns Boolean(Person)
# Args:
# 1: Array<Round>
Define("CompetesOrVolunteersInRound",
       If((Length({1, Array<Round>}) > 0),
          (CompetingInRound(At({1, Array<Round>}, 0)) || (NumJobsInRound(At({1, Array<Round>}, 0)) > 0)),
          false
         )
      )
