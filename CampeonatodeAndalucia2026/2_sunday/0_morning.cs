#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

Map([_333-r3, _555-r2, _clock-r2],
    AssignFixedGroups(Arg<Round>())
   )

AssignVolunteers(_333-r3, 16, 2, 2)
AssignVolunteers(_555-r2, 10, 2, 2)
AssignVolunteers(_clock-r2, 14, 2, 3)