#include "../lib/_assign.cs"
#include "../lib/_volunteers.cs"

# DEV
# AddResults(_444-r3, Persons((PsychSheetPosition(_444) <= 24)))
# AddResults(_222-r3, Persons((PsychSheetPosition(_222) <= 20)))
# AddResults(_333oh-r3, Persons((PsychSheetPosition(_333oh) <= 24)))
# AddResults(_skewb-r3, Persons((PsychSheetPosition(_skewb) <= 20)))

Map([_444-r3, _222-r3, _333oh-r3, _skewb-r3],
    FinalAssignGroups(Arg<Round>())
   )

FinalAssignStaff(_skewb-r3, x, true)
FinalAssignStaff(_333oh-r3, x, true)
FinalAssignStaff(_444-r3,   x, true)
FinalAssignStaff(_222-r3,   x, true)
