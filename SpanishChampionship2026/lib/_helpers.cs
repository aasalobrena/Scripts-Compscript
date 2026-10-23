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
# 2: Number: Number of competitors per group
Define("NumberPerGroupToPerRound",
       ({2, Number} * Length(Groups({1, Round})))
      )
