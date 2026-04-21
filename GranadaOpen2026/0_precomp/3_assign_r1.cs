#include "../lib/_assign.cs"
#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"
#include "../lib/_jobs.cs"
#include "../lib/_scorers.cs"

# 1 is other-checkin
ManuallyAssignActivity(1, Persons(true))

# 2 is other-tutorial
ManuallyAssignActivity(2, Persons(IsNull(WcaId())), STAFFALUMNO)
ManuallyAssignActivity(2, [2016GALA04, 2015SANC18])
ManuallyAssignActivity(2, [2018CAST11, 2025GRIM01], STAFFJUDGE)

AssignScramblers(_pyram-r1, 1, 3)
AssignScramblers(_pyram-r1, 2, 3)
AssignScramblers(_pyram-r1, 3, 3)
AssignScramblers(_pyram-r1, 4, 3)
AssignCompetitors(_pyram-r1)
ReAssignScramblers(_pyram-r1)
AssignStaff(
	_pyram-r1,
	true,
	Persons(true),
	DefaultJobs(_pyram-r1),
	DefaultStaffScorers(_pyram-r1)
)
ManuallyAssign(Persons(ChillsEvent(_pyram)), _pyram-r1, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_pyram)), _pyram-r1, SALON, 2, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_pyram)), _pyram-r1, SALON, 3, STAFFCHILL)
AssignStaff(_pyram-r1, true, Persons(CanDataEvent(_pyram)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_pyram-r1))

AssignScramblers(_444-r1, 1, 3)
AssignScramblers(_444-r1, 2, 3)
AssignScramblers(_444-r1, 3, 3)
AssignCompetitors(_444-r1)
ReAssignScramblers(_444-r1)
AssignStaff(
	_444-r1,
	true,
	Persons(true),
	DefaultJobs(_444-r1),
	DefaultStaffScorers(_444-r1)
)
ManuallyAssign(Persons(ChillsEvent(_444)), _444-r1, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_444)), _444-r1, SALON, 2, STAFFCHILL)
AssignStaff(_444-r1, true, Persons(CanDataEvent(_444)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_444-r1))

AssignScramblers(_sq1-r1, 1, 3)
AssignScramblers(_sq1-r1, 2, 3)
AssignCompetitors(_sq1-r1)
ReAssignScramblers(_sq1-r1)
AssignStaff(
	_sq1-r1,
	true,
	Persons(true),
	DefaultJobs(_sq1-r1),
	DefaultStaffScorers(_sq1-r1)
)
ManuallyAssign(Persons(ChillsEvent(_sq1)), _sq1-r1, SALON, 1, STAFFCHILL)
AssignStaff(_sq1-r1, true, Persons(CanDataEvent(_sq1)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_sq1-r1))

AssignScramblers(_333bf-r1, 1, 2)
AssignScramblers(_333bf-r1, 2, 2)
AssignCompetitors(_333bf-r1)
ReAssignScramblers(_333bf-r1)
AssignStaff(
	_333bf-r1,
	true,
	Persons(true),
	DefaultJobs(_333bf-r1),
	DefaultStaffScorers(_333bf-r1)
)
ManuallyAssign(Persons(ChillsEvent(_333bf)), _333bf-r1, SALON, 1, STAFFCHILL)
AssignStaff(_333bf-r1, true, Persons(CanDataEvent(_333bf)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_333bf-r1))

AssignScramblers(_clock-r1, 1, 3)
AssignScramblers(_clock-r1, 2, 3)
AssignScramblers(_clock-r1, 3, 3)
AssignCompetitors(_clock-r1)
ReAssignScramblers(_clock-r1)
AssignStaff(
	_clock-r1,
	true,
	Persons(true),
	DefaultJobs(_clock-r1),
	DefaultStaffScorers(_clock-r1)
)
ManuallyAssign(Persons(ChillsEvent(_clock)), _clock-r1, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_clock)), _clock-r1, SALON, 2, STAFFCHILL)
AssignStaff(_clock-r1, true, Persons(CanDataEvent(_clock)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_clock-r1))

AssignGroups(_333mbf-r1, EveryoneSet(), attemptNumber=1)
AssignStaff(_333mbf-r1, true, MbfJudges(), [Job(JUDGE, 3)], [])

AssignScramblersWithMbf(_222-r1, 1, 3)
AssignScramblersWithMbf(_222-r1, 2, 3)
AssignScramblersWithMbf(_222-r1, 3, 3)
AssignScramblersWithMbf(_222-r1, 4, 3)
AssignScramblersWithMbf(_222-r1, 5, 3)
AssignGroups(_222-r1,
	Concat(ChillSet(_222-r1), [AssignmentSet("mbf", HasMbfAssignments(), In(GroupNumber(), [1, 2]))], DelegatesSet(), OrganizersSet(), DeLaTorreSet(), UkuSet(), EveryoneSet()),
	ScramblingCompetingScorers(_222-r1),
	[StationAssignmentRule(true, "ascending", PsychSheetPosition(_222))],
	overwrite=true
)
ReAssignScramblers(_222-r1)
AssignStaff(
	_222-r1,
	true,
	Persons(Not(HasMbfAssignments())),
	MbfJobs(_222-r1),
	DefaultStaffScorers(_222-r1)
)
ManuallyAssign(Persons(ChillsEvent(_222)), _222-r1, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_222)), _222-r1, SALON, 2, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_222)), _222-r1, SALON, 3, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_222)), _222-r1, SALON, 4, STAFFCHILL)
AssignStaff(_222-r1, true, Persons(CanDataEvent(_222)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_222-r1))

AssignScramblersWithMbf(_333-r1, 1, 3)
AssignScramblersWithMbf(_333-r1, 2, 3)
AssignScramblersWithMbf(_333-r1, 3, 3)
AssignScramblersWithMbf(_333-r1, 4, 3)
AssignScramblersWithMbf(_333-r1, 5, 3)
AssignGroups(_333-r1,
	Concat(ChillSet(_333-r1), [AssignmentSet("mbf", HasMbfAssignments(), (GroupNumber() == 4)), AssignmentSet("delegates", HasRole("delegate"), In(GroupNumber(), [4, 5]))], OrganizersSet(), DeLaTorreSet(), UkuSet(), EveryoneSet()),
	ScramblingCompetingScorers(_333-r1),
	[StationAssignmentRule(true, "ascending", PsychSheetPosition(_333))],
	overwrite=true
)
ReAssignScramblers(_333-r1)
AssignStaff(
	_333-r1,
	true,
	Persons(Not(HasMbfAssignments())),
	MbfJobs(_333-r1),
	DefaultStaffScorers(_333-r1)
)
ManuallyAssign(Persons(ChillsEvent(_333)), _333-r1, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_333)), _333-r1, SALON, 2, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_333)), _333-r1, SALON, 3, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_333)), _333-r1, SALON, 4, STAFFCHILL)
AssignStaff(_333-r1, true, Persons(CanDataEvent(_333)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_333-r1))

AssignScramblers(_skewb-r1, 1, 3)
AssignScramblers(_skewb-r1, 2, 3)
AssignScramblers(_skewb-r1, 3, 3)
AssignCompetitors(_skewb-r1)
ReAssignScramblers(_skewb-r1)
AssignStaff(
	_skewb-r1,
	true,
	Persons(true),
	DefaultJobs(_skewb-r1),
	DefaultStaffScorers(_skewb-r1)
)
ManuallyAssign(Persons(ChillsEvent(_skewb)), _skewb-r1, SALON, 1, STAFFCHILL)
ManuallyAssign(Persons(ChillsEvent(_skewb)), _skewb-r1, SALON, 2, STAFFCHILL)
AssignStaff(_skewb-r1, true, Persons(CanDataEvent(_skewb)), [Job(DATAENTRY, 1)], DefaultStaffScorers(_skewb-r1))

# 6 is other-awards
ManuallyAssignActivity(6, Persons(HasRole(ORGANIZER)), STAFFANNOUNCER)