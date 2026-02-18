#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_unavailabilities.cs"

AssignGroups(_333mbf-r1, [AssignmentSet("everyone", true, true)], attemptNumber=1)
AssignGroups(_333mbf-r1, [AssignmentSet("everyone", true, true)], attemptNumber=2)
AssignStaff(_333mbf-r1,
            true,
            Persons(true),
            [Job("judge",
                 Length(Persons(In(333mbf_JUDGE, ArrayProperty(AUX_TASKS)))),
                 eligibility=In(333mbf_JUDGE, ArrayProperty(AUX_TASKS))),
             Job("delegate",
                 Length(Persons(In(333mbf_DELEGATE, ArrayProperty(AUX_TASKS)))),
                 eligibility=In(333mbf_DELEGATE, ArrayProperty(AUX_TASKS)))],
            [],
            unavailable=Unavailable(Arg<Person>()))

AssignGroupsAux(_444bf-r1)
AssignStaffAux(_444bf-r1)

AssignGroupsAux(_555bf-r1)
AssignStaffAux(_555bf-r1)

CreateCompetitionGroupsAssignments(Persons((StringProperty(TEAM) == AUX_TEAM)),
                                   "Aux Room Setup",
                                   2025-12-06T12:20,
                                   2025-12-06T12:50)
CreateCompetitionGroupsAssignments(Persons((StringProperty(TEAM) == AUX_TEAM)),
                                   "3x3x3 Multi-Blind Scrambling",
                                   2025-12-06T12:50,
                                   2025-12-06T13:10)
CreateCompetitionGroupsAssignments(Persons((StringProperty(TEAM) == AUX_TEAM)),
                                   "Aux Room Setup",
                                   2025-12-07T08:30,
                                   2025-12-07T09:00)
CreateCompetitionGroupsAssignments(Persons((StringProperty(TEAM) == AUX_TEAM)),
                                   "3x3x3 Multi-Blind Scrambling",
                                   2025-12-07T09:00,
                                   2025-12-07T09:20)