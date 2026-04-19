#include "_constants.cs"
#include "_helpers.cs"

# Args:
# 1: Round
Define("ChillSet",
       [AssignmentSet(EventId(EventForRound({1, Round})),
                      (StringProperty(CHILL) == EventId(EventForRound({1, Round}))),
                      (GroupNumber() == Length(Groups({1, Round})))
                     )
       ]
      )

Define("DelegatesSet",
       [AssignmentSet("delegates",
                      Or(HasRole(DELEGATE),
                         HasRole(TRAINEE)
                        ),
                      true
                     )
       ]
      )

Define("OrganizersSet",
       [AssignmentSet("organizers",
                      HasRole(ORGANIZER),
                      true
                     )
       ]
      )

Define("DeLaTorreSet",
       [AssignmentSet("delatorre",
                      In(WcaId(),
                         ["2023LAME03", "2024LAME01"]
                        ),
                      true
                     )
       ]
      )

Define("UkuSet",
       [AssignmentSet("ukubom",
                      In(WcaId(),
                         UkuIds()
                        ),
                      true
                     )
       ]
      )

# Args:
# 1: Round
Define("TopCompetitorsSet",
       [AssignmentSet("topcompetitors",
                      And(IsTopCompetitor({1, Round}),
                          Not(IsTopScrambler({1, Round}))
                         ),
                      (GroupNumber() == Length(Groups({1, Round})))
                     )
       ]
      )

Define("EveryoneSet", 
       [AssignmentSet("everyone",
                      true,
                      true
                     )
       ]
      )

# Args:
# 1: Round
Define("DefaultAssignmentSets",
       Concat(ChillSet({1, Round}),
              DelegatesSet(),
              OrganizersSet(),
              DeLaTorreSet(),
              UkuSet(),
              TopCompetitorsSet({1, Round}),
              EveryoneSet()
             )
      )