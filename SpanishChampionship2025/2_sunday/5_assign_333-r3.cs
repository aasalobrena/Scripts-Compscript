#include "../lib/_constants.cs"
#include "../lib/_assign.cs"

AssignGroups(_333-r3,
             [AssignmentSet("red",
                            (RoundPosition(_333-r2) <= 14),
                            (Stage() == RED)),
              AssignmentSet("yellow",
                            (RoundPosition(_333-r2) <= 29),
                            (Stage() == YELLOW)),
              AssignmentSet("green",
                            (RoundPosition(_333-r2) <= 43),
                            (Stage() == GREEN))],
             stationRules=[StationAssignmentRule(true,
                           "ascending",
                           RoundPosition(_333-r2))])
AssignStaffStages(_333-r3, 2025-12-08, 16, 3, 4, 1)