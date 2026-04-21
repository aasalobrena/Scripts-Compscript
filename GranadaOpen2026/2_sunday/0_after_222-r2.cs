#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"

AssignGroups(_333-r3, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_333-r2))])
AssignStaff(
	_333-r3,
	true,
	Persons(true),
	FinalJobs(_333-r3, 3),
	DefaultStaffScorers(_333-r3)
)

AssignGroups(_222-r3, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_222-r2))])
AssignStaff(
	_222-r3,
	true,
	Persons(true),
	FinalJobs(_222-r3, 3),
	DefaultStaffScorers(_222-r3)
)