#include "../lib/_assign.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"

AssignScramblers(_pyram-r2, 1, 3)
AssignScramblers(_pyram-r2, 2, 3)
AssignCompetitors(_pyram-r2)
ReAssignScramblers(_pyram-r2)
AssignStaff(
	_pyram-r2,
	true,
	Persons(true),
	DefaultJobs(_pyram-r2),
	DefaultStaffScorers(_pyram-r2)
)
ManuallyAssign(Persons(And(ChillsEvent(_pyram), CompetingInRound(_pyram-r2))), _pyram-r2, SALON, 1, STAFFCHILL)
AssignStaff(_pyram-r2, true, Persons(HasRole(STAFFDATAENTRY)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_pyram-r2))

AssignScramblers(_444-r2, 1, 3)
AssignScramblers(_444-r2, 2, 3)
AssignCompetitors(_444-r2)
ReAssignScramblers(_444-r2)
AssignStaff(
	_444-r2,
	true,
	Persons(true),
	DefaultJobs(_444-r2),
	DefaultStaffScorers(_444-r2)
)
ManuallyAssign(Persons(And(ChillsEvent(_444), CompetingInRound(_444-r2))), _444-r2, SALON, 1, STAFFCHILL)
AssignStaff(
	_444-r2,
	true,
	Persons(HasRole(STAFFDATAENTRY)),
	[Job(DATAENTRY, 1)],
	DefaultStaffScorers(_444-r2)
)