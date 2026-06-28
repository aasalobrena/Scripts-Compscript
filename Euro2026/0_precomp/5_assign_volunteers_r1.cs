#include "../lib/_assign.cs"
#include "../lib/_constants.cs"

AssignStaffSide(_333fm-r1,   FM)
AssignStaffSide(_333mbf-r1, MBF)

ManuallyAssign(Persons((StringProperty(TYPE) == SIDE)),
               _444bf-r1,
               SIDEROOM,
               1,
               STAFFJUDGE
              )
ManuallyAssign(Persons((StringProperty(TYPE) == SIDELEADER)),
               _444bf-r1,
               SIDEROOM,
               1,
               STAFFDELEGATE
              )
ManuallyAssign(Persons((StringProperty(TYPE) == SIDE)),
               _555bf-r1,
               SIDEROOM,
               1,
               STAFFJUDGE
              )
ManuallyAssign(Persons((StringProperty(TYPE) == SIDELEADER)),
               _555bf-r1,
               SIDEROOM,
               1,
               STAFFDELEGATE
              )

Map([1, 2, 3, 4, 5], AssignStaffR1(_333oh-r1, 2026-07-16, Arg<Number>(),   15s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_777-r1,   2026-07-16, Arg<Number>(), 3:00s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_444-r1,   2026-07-16, Arg<Number>(),   45s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_clock-r1, 2026-07-16, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_skewb-r1, 2026-07-17, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_666-r1,   2026-07-17, Arg<Number>(), 2:50s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_333bf-r1, 2026-07-17, Arg<Number>(),   15s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_sq1-r1,   2026-07-17, Arg<Number>(),   15s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_222-r1,   2026-07-17, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_minx-r1,  2026-07-17, Arg<Number>(),   45s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_555-r1,   2026-07-18, Arg<Number>(), 1:00s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_pyram-r1, 2026-07-18, Arg<Number>(),    6s, 20))
Map([1, 2, 3, 4, 5], AssignStaffR1(_333-r1,   2026-07-18, Arg<Number>(),   15s, 20))