#include "../lib/_assign.cs"
#include "../lib/_volunteers.cs"

# DEV
# AddResults(_minx-r2, Persons((PsychSheetPosition(_minx) <= 22)))
# AddResults(_333bf-r3, Persons((PsychSheetPosition(_333bf) <= 25)))

Map([_minx-r2, _333bf-r3],
    FinalAssignGroups(Arg<Round>())
   )

FinalAssignStaff(_minx-r2,  x)
FinalAssignStaff(_333bf-r3, x)
