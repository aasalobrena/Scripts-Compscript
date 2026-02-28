#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

Map([_333-r1, _222-r1, _444-r1, _555-r1, _333oh-r1, _pyram-r1, _sq1-r1],
    AssignWaitingGroups(Arg<Round>())
   )

Map([_666-r1, _777-r1, _333bf-r1, _clock-r1, _minx-r1, _skewb-r1],
    AssignFixedGroups(Arg<Round>())
   )

Map([_777-r1, _666-r1, _444-r1, _pyram-r1, _sq1-r1, _skewb-r1,
     _333-r1, _222-r1, _333oh-r1, _333bf-r1, _minx-r1],
    AssignVolunteers(Arg<Round>(), 2026-03-07, 16, 3, ScramblersPerRound(Arg<Round>()))
   )

Map([_clock-r1, _555-r1],
    AssignVolunteers(Arg<Round>(), 2026-03-08, 16, 3, ScramblersPerRound(Arg<Round>()))
   )