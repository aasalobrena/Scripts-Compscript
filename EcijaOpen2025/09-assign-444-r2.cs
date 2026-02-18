#include "helpers.cs"

#AddResults(_444-r2, Persons((PsychSheetPosition(_444) <= 8)))

AssignGroups(_444-r2, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_444-r1))])
AssignStaff(
	_444-r2,
	true,
	Persons(true),
	FinalJobs(_444-r2, 3),
	DefaultStaffScorers(_444-r2)
)