#include "../lib/_assign.cs"

# DEV:
Map(Events(), AddResults(RoundForEvent(1, Arg<Event>()), Persons(CompetingIn())))

AssignGroups(_333fm-r1,  [EveryoneSet()], attemptNumber=1)
AssignGroups(_333fm-r1,  [EveryoneSet()], attemptNumber=2)
AssignGroups(_333fm-r1,  [EveryoneSet()], attemptNumber=3)
AssignGroups(_444bf-r1,  [EveryoneSet()])
AssignGroups(_555bf-r1,  [EveryoneSet()])
AssignGroups(_333mbf-r1, [EveryoneSet()], attemptNumber=1)
AssignGroups(_333mbf-r1, [EveryoneSet()], attemptNumber=2)

AssignGroupsR1(_333-r1,   [_333fm-r1],        [7, 8],              2026-07-18, 10, 50)
AssignGroupsR1(_222-r1,   [_333mbf-r1],       [1, 2],              2026-07-17, 10, 50)
AssignGroupsR1(_444-r1,   [_333mbf-r1],       [3, 4],              2026-07-16, 10, 50)
AssignGroupsR1(_555-r1,   [_444bf-r1],        [4],                 2026-07-18, 10, 50)
AssignGroupsR1(_666-r1,   [_333fm-r1],        [2],                 2026-07-17, 10, 25)
AssignGroupsR1(_777-r1,   [_333fm-r1],        [2],                 2026-07-16, 10, 25)
AssignGroupsR1(_333bf-r1, MakeArray<Round>(), MakeArray<Number>(), 2026-07-17, 10, 25)
AssignGroupsR1(_333oh-r1, [_333fm-r1],        [1, 2],              2026-07-16, 10, 50)
AssignGroupsR1(_clock-r1, [_333mbf-r1],       [5],                 2026-07-16, 10, 50)
AssignGroupsR1(_minx-r1,  [_333mbf-r1],       [2, 3],              2026-07-17, 10, 25)
AssignGroupsR1(_pyram-r1, [_555bf-r1],        [1],                 2026-07-18, 10, 50)
AssignGroupsR1(_skewb-r1, [_333fm-r1],        [1],                 2026-07-17, 10, 50)
AssignGroupsR1(_sq1-r1,   [_333mbf-r1],       [3],                 2026-07-17, 10, 25)