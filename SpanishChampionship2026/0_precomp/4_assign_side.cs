#include "../lib/_assignment_sets.cs"
#include "../lib/_constants.cs"
#include "../lib/_helpers.cs"
#include "../lib/_jobs.cs"
#include "../lib/_unavailabilities.cs"

# Returns StationAssignmentRule
# Args:
# 1: Event
Define("SideStations",
       StationAssignmentRule(true, "ascending", PsychSheetPosition({1, Event}))
      )

Map([_444bf-r1, _555bf-r1],
    AssignGroups(Arg<Round>(), [EveryoneSet()], stationRules=SideStations(EventForRound(Arg<Round>())))
   )
Map([1, 2],
    AssignGroups(_333mbf-r1, [EveryoneSet()], stationRules=SideStations(_333mbf), attemptNumber=Arg<Number>())
   )

Map([_444bf-r1, _555bf-r1],
    AssignStaff(Arg<Round>(),
                true,
                TeamWithDelegateCluster([STAGE_TEAM, SIDE_TEAM], [1]),
                [JudgeJob(20), RunnerJob(2), ScramblerJob(2, EventForRound(Arg<Round>())), DelegateJob(1)],
                scorers(), # dummy
                unavailable=Unavailable(Arg<Person>())
               )
   )
AssignStaff(_333mbf-r1,
            true,
            TeamWithDelegateCluster([STAGE_TEAM, SIDE_TEAM], [1]),
            [JudgeJob(10), DelegateJob(1)],
            scorers(), # dummy
            unavailable=Unavailable(Arg<Person>())
           )
