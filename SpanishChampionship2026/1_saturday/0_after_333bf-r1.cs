#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_volunteers.cs"

# DEV
# AddResults(_clock-r2, Persons((PsychSheetPosition(_clock) <= 20)))
# AddResults(_777-r2, Persons((PsychSheetPosition(_777) <= 26)))
# AddResults(_sq1-r2, Persons((PsychSheetPosition(_sq1) <= 20)))
# AddResults(_666-r2, Persons((PsychSheetPosition(_666) <= 26)))
# AddResults(_333bf-r2, Persons((PsychSheetPosition(_333bf) <= 50)))

Map([_clock-r2, _777-r2, _sq1-r2, _666-r2],
    FinalAssignGroups(Arg<Round>())
   )
AssignGroups(_333bf-r2,
             [AssignmentSet(BIZKAIA_STAGE,
                            (Seed(_333bf-r2) <= 23),
                            (Stage() == BIZKAIA_STAGE)
                           ),
              AssignmentSet(GIPUZKOA_STAGE,
                            true,
                            (Stage() == GIPUZKOA_STAGE)
                           )
             ]
            )

AllStagesAssignStaff(_333bf-r2)
FinalAssignStaff(_777-r2,   x)
FinalAssignStaff(_clock-r2, x)
FinalAssignStaff(_sq1-r2,   x)
FinalAssignStaff(_666-r2,   x)
