#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

Map([_444-r2, _pyram-r2, _skewb-r2, _sq1-r2],
    AssignFixedGroups(Arg<Round>())
   )

AssignVolunteers(_sq1-r2, 10, 2, 2)
AssignVolunteers(_skewb-r2, 12, 2, 2)
AssignVolunteers(_pyram-r2, 16, 2, 2)
AssignVolunteers(_444-r2, 12, 2, 3)