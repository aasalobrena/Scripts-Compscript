#include "../lib/_constants.cs"
#include "../lib/_volunteers.cs"

# DEV
# AddResults(_333-r4, Persons((PsychSheetPosition(_333) <= 23)))

AssignGroups(_333-r4,
             [AssignmentSet(BIZKAIA_STAGE,
                            (Country() == "ES"),
                            (Stage() == BIZKAIA_STAGE)
                           ),
              AssignmentSet(GIPUZKOA_STAGE,
                            true,
                            (Stage() == GIPUZKOA_STAGE)
                           )
             ],
             stationRules=[StationAssignmentRule((Stage() == GIPUZKOA_STAGE),
                                                 "ascending",
                                                 Seed(_333-r4)
                                                )
                          ]
            )

FinalAssignStaff(_333-r4, x, false)
