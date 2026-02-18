#include "helpers.cs"

#AddResults(_pyram-r2, Persons((RoundPosition(_pyram-r1) <= 12)))

AssignGroups(_pyram-r2, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_pyram-r1))])
AssignStaff(
	_pyram-r2,
	true,
	Persons(true),
	FinalJobs(_pyram-r2, 3),
	DefaultStaffScorers(_pyram-r2)
)