#include "../lib/_constants.cs"
#include "../lib/_volunteers.cs"

# DEV
# AddResults(_333-r3, Persons((PsychSheetPosition(_333) <= 42)))

AssignGroups(_333-r3,
             [AssignmentSet(BIZKAIA_STAGE,
                            (Seed(_333-r3) <= 14),
                            (Stage() == BIZKAIA_STAGE)
                           ),
              AssignmentSet(GIPUZKOA_STAGE,
                            (Seed(_333-r3) <= 28),
                            (Stage() == GIPUZKOA_STAGE)
                           ),
              AssignmentSet(ARABA_STAGE,
                            true,
                            (Stage() == ARABA_STAGE)
                           )
             ],
             stationRules=[StationAssignmentRule(true, "ascending", Seed(_333-r3))]
            )

AllStagesAssignStaff(_333-r3)
