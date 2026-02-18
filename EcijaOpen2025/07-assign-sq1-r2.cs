#include "helpers.cs"

#AddResults(_sq1-r2, Persons((PsychSheetPosition(_sq1) <= 16)))

AssignScramblers(_sq1-r2, 1, 3)
AssignScramblers(_sq1-r2, 2, 3)
AssignCompetitors(_sq1-r2)
ReAssignScramblers(_sq1-r2)
AssignStaff(
	_sq1-r2,
	true,
	Persons(true),
	DefaultJobs(_sq1-r2),
	DefaultStaffScorers(_sq1-r2)
)