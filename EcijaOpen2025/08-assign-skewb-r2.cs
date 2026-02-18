#include "helpers.cs"

#AddResults(_skewb-r2, Persons((PsychSheetPosition(_skewb) <= 32)))

AssignScramblers(_skewb-r2, 1, 3)
AssignScramblers(_skewb-r2, 2, 3)
AssignCompetitors(_skewb-r2)
ReAssignScramblers(_skewb-r2)
AssignStaff(
	_skewb-r2,
	true,
	Persons(true),
	DefaultJobs(_skewb-r2),
	DefaultStaffScorers(_skewb-r2)
)