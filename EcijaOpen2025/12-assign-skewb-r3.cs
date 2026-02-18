#include "helpers.cs"

#AddResults(_skewb-r3, Persons((PsychSheetPosition(_skewb) <= 12)))

AssignGroups(_skewb-r3, EveryoneSet(), stationRules=[StationAssignmentRule(true, "ascending", RoundPosition(_skewb-r2))])
AssignStaff(
	_skewb-r3,
	true,
	Persons(true),
	FinalJobs(_skewb-r3, 3),
	DefaultStaffScorers(_skewb-r3)
)