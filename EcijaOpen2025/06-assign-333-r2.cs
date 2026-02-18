#include "helpers.cs"

#AddResults(_333-r2, Persons((PsychSheetPosition(_333) <= 48)))

AssignScramblers(_333-r2, 1, 3)
AssignScramblers(_333-r2, 2, 3)
AssignScramblers(_333-r2, 3, 3)
AssignCompetitors(_333-r2)
ReAssignScramblers(_333-r2)
AssignStaff(
	_333-r2,
	true,
	Persons(true),
	DefaultJobs(_333-r2),
	DefaultStaffScorers(_333-r2)
)