#include "_constants.cs"

# Args:
# 1: Round
Define("TopCompetitorsPerRound", (Length(Filter(Groups({1, Round}), (Stage() == GREEN))) * 4))

# Args:
# 1: Round
Define("TopCompetitorsSet",
       AssignmentSet("top",
                     If((RoundNumber({1, Round}) == 1),
                        (PsychSheetPosition(EventForRound({1, Round})) <= TopCompetitorsPerRound({1, Round})),
                        (RoundPosition(PreviousRound({1, Round})) <= TopCompetitorsPerRound({1, Round}))
                       ),
                     (Stage() == GREEN)
                    )
      )

Define("OrganizersSet",
       AssignmentSet("organizers",
                     HasRole(ORGANIZER),
                     (Stage() == GREEN)
                    )
      )

Define("DelegatesSet",
       AssignmentSet("delegates",
                     HasRole(DELEGATE),
                     (Stage() == GREEN)
                    )
      )

Define("EveryoneSet", AssignmentSet("everyone", true, true))

# Args:
# 1: Round
Define("NormalRoundAssignmentSets",
       [TopCompetitorsSet({1, Round}),
        OrganizersSet(),
        DelegatesSet(),
        EveryoneSet()
       ]
      )