#include "helpers.cs"

#AddResults(_222-r2, Persons((PsychSheetPosition(_222) <= 32)))

AssignScramblers(_222-r2, 1, 3)
AssignScramblers(_222-r2, 2, 3)
AssignCompetitors(_222-r2)
ReAssignScramblers(_222-r2)
AssignStaff(
	_222-r2,
	true,
	Persons(true),
	DefaultJobs(_222-r2),
	DefaultStaffScorers(_222-r2)
)