#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_volunteers.cs"

Map([_clock-r2, _777-r2, _sq1-r2, _666-r2],
    FinalAssignGroups(Arg<Round>())
   )
AssignGroups(_333bf-r2,
             [AssignmentSet(BIZKAIA_STAGE,
                            (Seed(_333bf-r2) <= 25),
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
