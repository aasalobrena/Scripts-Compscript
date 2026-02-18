#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

Map([_777-r1, _clock-r1, _666-r1, _333oh-r1, _sq1-r1, _minx-r1, _555-r1, _333bf-r1,
     _222-r1, _333-r1, _pyram-r1, _skewb-r1, _444-r1],
    AssignGroupsStages(Arg<Round>(),
                       TopCompetitorsPerRound(Arg<Round>()),
                       Not(In(Arg<Round>(),
                              [_333oh-r1, _sq1-r1, _minx-r1, _555-r1, _333-r1, _skewb-r1]))))

ManuallyAssign([2018CAST11, 2013GARC08], _333oh-r1, YELLOW, 1)
ManuallyAssign([2015ROYC01, 2016LOPE37], _333oh-r1, GREEN, 1)
ManuallyAssign([2017NICO01], _333oh-r1, RED, 2)

ManuallyAssign([2013GARC08], _sq1-r1, YELLOW, 1)
ManuallyAssign([2018CAST11], _sq1-r1, GREEN, 1)
ManuallyAssign([2016LOPE37], _sq1-r1, RED, 2)
ManuallyAssign([2015ROYC01], _sq1-r1, YELLOW, 2)
ManuallyAssign([2016PERE44], _sq1-r1, GREEN, 2)

ManuallyAssign([2013GARC08], _minx-r1, YELLOW, 1)
ManuallyAssign([2015ROYC01], _minx-r1, GREEN, 1)
ManuallyAssign([2017NICO01], _minx-r1, RED, 2)

ManuallyAssign([2016LOPE37], _555-r1, RED, 1)
ManuallyAssign([2016PERE44], _555-r1, RED, 2)
ManuallyAssign([2015ROYC01, 2013GARC08], _555-r1, YELLOW, 3)
ManuallyAssign([2015SANC18, 2017NICO01], _555-r1, GREEN, 3)

ManuallyAssign([2015ROYC01], _333-r1, RED, 1)
ManuallyAssign([2016PERE44], _333-r1, YELLOW, 2)
ManuallyAssign([2017NICO01], _333-r1, GREEN, 3)
ManuallyAssign([2016LOPE37], _333-r1, YELLOW, 4)
ManuallyAssign([2018CAST11], _333-r1, RED, 5)
ManuallyAssign([2015SANC18], _333-r1, YELLOW, 5)
ManuallyAssign([2013GARC08], _333-r1, GREEN, 5)

ManuallyAssign([2015SANC18], _skewb-r1, RED, 1)
ManuallyAssign([2018CAST11], _skewb-r1, YELLOW, 1)
ManuallyAssign([2013GARC08], _skewb-r1, GREEN, 1)
ManuallyAssign([2015ROYC01], _skewb-r1, RED, 2)
ManuallyAssign([2016PERE44], _skewb-r1, YELLOW, 2)
ManuallyAssign([2017NICO01, 2016LOPE37], _skewb-r1, GREEN, 2)

Map([_777-r1, _clock-r1, _666-r1, _333oh-r1, _sq1-r1, _minx-r1, _555-r1, _333bf-r1],
    AssignStaffStages(Arg<Round>(), 2025-12-06, 16, 3, 4, 1))

Map([_222-r1, _333-r1, _pyram-r1, _skewb-r1, _444-r1],
    AssignStaffStages(Arg<Round>(), 2025-12-07, 16, 3, 4, 1))