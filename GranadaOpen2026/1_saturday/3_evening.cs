#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"

AssignGroups(_skewb-r2, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_skewb-r1))])
AssignStaff(
	_skewb-r2,
	true,
	Persons(true),
	FinalJobs(_skewb-r2, 3),
	DefaultStaffScorers(_skewb-r2)
)

AssignGroups(_pyram-r3, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_pyram-r2))])
AssignStaff(
	_pyram-r3,
	true,
	Persons(true),
	FinalJobs(_pyram-r3, 3),
	DefaultStaffScorers(_pyram-r3)
)

AssignGroups(_444-r3, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_444-r2))])
AssignStaff(
	_444-r3,
	true,
	Persons(true),
	FinalJobs(_444-r3, 3),
	DefaultStaffScorers(_444-r3)
)