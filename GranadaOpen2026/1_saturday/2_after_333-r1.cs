#include "../lib/_assign.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"

AssignScramblers(_222-r2, 1, 3)
AssignScramblers(_222-r2, 2, 3)
AssignScramblers(_222-r2, 3, 3)
AssignCompetitors(_222-r2)
ReAssignScramblers(_222-r2)
AssignStaff(
	_222-r2,
	true,
	Persons(true),
	DefaultJobs(_222-r2),
	DefaultStaffScorers(_222-r2)
)
ManuallyAssign(Persons(And(ChillsEvent(_222), CompetingInRound(_222-r2))), _222-r2, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(And(ChillsEvent(_222), CompetingInRound(_222-r2))), _222-r2, SALON, 2, STAFFCHILL)
AssignStaff(_222-r2, true, Persons(HasRole(STAFFDATAENTRY)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_222-r2))

# 73 is other-awards-333mbf
ManuallyAssignActivity(73, Persons((RoundPosition(_333mbf-r1) == 1)), STAFFWINNER)
ManuallyAssignActivity(73, Persons((RoundPosition(_333mbf-r1) == 2)), STAFFRUNNERUP)
ManuallyAssignActivity(73, Persons((RoundPosition(_333mbf-r1) == 3)), STAFFTHIRD)

AssignScramblers(_333-r2, 1, 3)
AssignScramblers(_333-r2, 2, 3)
AssignCompetitors(_333-r2)
ReAssignScramblers(_333-r2)
AssignStaff(
	_333-r2,
	true,
	Persons(true),
	DefaultJobs(_333-r2),
	DefaultStaffScorers(_333-r2)
)
ManuallyAssign(Persons(And(ChillsEvent(_333), CompetingInRound(_333-r2))), _333-r2, SALON, 1, STAFFCHILL)
AssignStaff(_333-r2, true, Persons(HasRole(STAFFDATAENTRY)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_333-r2))