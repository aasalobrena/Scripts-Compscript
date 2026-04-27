#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"

AssignGroups(_sq1-r2, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_sq1-r1))])
AssignStaff(
	_sq1-r2,
	true,
	Persons(true),
	FinalJobs(_sq1-r2, 3),
	DefaultStaffScorers(_sq1-r2)
)

AssignGroups(_333bf-r2, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_333bf-r1))])
AssignStaff(
	_333bf-r2,
	true,
	Persons(true),
	FinalJobs(_333bf-r2, 2),
	DefaultStaffScorers(_333bf-r2)
)

AssignGroups(_clock-r2, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_clock-r1))])
AssignStaff(
	_clock-r2,
	true,
	Persons(true),
	FinalJobs(_clock-r2, 3),
	DefaultStaffScorers(_clock-r2)
)