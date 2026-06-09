#include "../lib/_constants.cs"

CreateRoom(HALL123,     "#2a3189")
CreateRoom(HALL5,       "#0b072a")
CreateRoom(SIDEROOM,    "#db031d")

CreateStage(ORANGE, HALL123, "#f28507")
CreateStage(BLUE,   HALL123, "#304a96")
CreateStage(GREEN,  HALL123, "#1ca61e")
CreateStage(RED,    HALL5,   "#e21212")
CreateStage(YELLOW, HALL5,   "#f7ef18")

# Side Room
CreateGroups(_333fm-r1-a1,  1, SIDEROOM, 2026-07-16T09:55, 2026-07-16T11:10, useStageName=false)
CreateGroups(_333fm-r1-a2,  1, SIDEROOM, 2026-07-17T09:30, 2026-07-17T10:45, useStageName=false)
CreateGroups(_333fm-r1-a3,  1, SIDEROOM, 2026-07-18T15:00, 2026-07-18T16:15, useStageName=false)
CreateGroups(_444bf-r1,     1, SIDEROOM, 2026-07-18T09:10, 2026-07-18T09:55, useStageName=false)
CreateGroups(_555bf-r1,     1, SIDEROOM, 2026-07-18T11:35, 2026-07-18T12:30, useStageName=false)
CreateGroups(_333mbf-r1-a1, 1, SIDEROOM, 2026-07-16T15:40, 2026-07-16T16:55, useStageName=false)
CreateGroups(_333mbf-r1-a2, 1, SIDEROOM, 2026-07-17T15:20, 2026-07-17T16:35, useStageName=false)

# Thursday
Map(AllStages(), CreateGroups(_333oh-r1, 6, 2026-07-16T09:00, 2026-07-16T11:15))
Map(AllStages(), CreateGroups(_777-r1,   2, 2026-07-16T11:15, 2026-07-16T12:15))
Map(AllStages(), CreateGroups(_444-r1,   6, 2026-07-16T13:40, 2026-07-16T16:10))
Map(AllStages(), CreateGroups(_clock-r1, 4, 2026-07-16T16:10, 2026-07-16T17:35))
Map(AllStages(), CreateGroups(_333oh-r2, 1, 2026-07-16T17:35, 2026-07-16T18:00))
Map(AllStages(), CreateGroups(_444-r2,   1, 2026-07-16T18:00, 2026-07-16T18:25))
Map(AllStages(), CreateGroups(_clock-r2, 1, 2026-07-16T18:25, 2026-07-16T18:50))

# Friday
Map(AllStages(),    CreateGroups(_skewb-r1, 6, 2026-07-17T09:00, 2026-07-17T10:45))
Map(AllStages(),    CreateGroups(_666-r1,   2, 2026-07-17T10:45, 2026-07-17T11:40))
Map(AllStages(),    CreateGroups(_333bf-r1, 2, 2026-07-17T11:40, 2026-07-17T12:20))
Map(AllStages(),    CreateGroups(_sq1-r1,   3, 2026-07-17T13:20, 2026-07-17T14:20))
Map(AllStages(),    CreateGroups(_222-r1,   7, 2026-07-17T14:20, 2026-07-17T16:30))
Map(AllStages(),    CreateGroups(_minx-r1,  3, 2026-07-17T16:30, 2026-07-17T17:45))
Map(FinalsStages(), CreateGroups(_777-r2,   1, 2026-07-17T17:55, 2026-07-17T18:20))
Map(FinalsStages(), CreateGroups(_333oh-r3, 1, 2026-07-17T18:20, 2026-07-17T18:45))
Map(FinalsStages(), CreateGroups(_clock-r3, 1, 2026-07-17T18:45, 2026-07-17T19:10))
Map(FinalsStages(), CreateGroups(_444-r3,   1, 2026-07-17T19:10, 2026-07-17T19:35))

# Saturday
Map(AllStages(),    CreateGroups(_555-r1,   4, 2026-07-18T09:00, 2026-07-18T10:50))
Map(AllStages(),    CreateGroups(_pyram-r1, 5, 2026-07-18T10:50, 2026-07-18T12:35))
Map(AllStages(),    CreateGroups(_222-r2,   1, 2026-07-18T13:35, 2026-07-18T13:55))
Map(AllStages(),    CreateGroups(_minx-r2,  1, 2026-07-18T13:55, 2026-07-18T14:20))
Map(AllStages(),    CreateGroups(_skewb-r2, 1, 2026-07-18T14:20, 2026-07-18T14:40))
Map(AllStages(),    CreateGroups(_333-r1,   8, 2026-07-18T14:40, 2026-07-18T17:40))
Map(FinalsStages(), CreateGroups(_666-r2,   1, 2026-07-18T17:50, 2026-07-18T18:15))
Map(FinalsStages(), CreateGroups(_skewb-r3, 1, 2026-07-18T18:15, 2026-07-18T18:40))
Map(FinalsStages(), CreateGroups(_minx-r3,  1, 2026-07-18T18:40, 2026-07-18T19:05))
Map(FinalsStages(), CreateGroups(_222-r3,   1, 2026-07-18T19:05, 2026-07-18T19:30))

# Sunday
Map(AllStages(),    CreateGroups(_333-r2,   4, 2026-07-19T10:00, 2026-07-19T11:30))
Map(AllStages(),    CreateGroups(_555-r2,   1, 2026-07-19T11:30, 2026-07-19T12:00))
Map(AllStages(),    CreateGroups(_pyram-r2, 1, 2026-07-19T12:00, 2026-07-19T12:20))
Map(AllStages(),    CreateGroups(_333bf-r2, 1, 2026-07-19T12:20, 2026-07-19T12:40))
Map(AllStages(),    CreateGroups(_sq1-r2,   1, 2026-07-19T12:40, 2026-07-19T13:00))
Map(AllStages(),    CreateGroups(_333-r3,   1, 2026-07-19T13:00, 2026-07-19T13:25))
Map(FinalsStages(), CreateGroups(_555-r3,   1, 2026-07-19T14:25, 2026-07-19T14:50))
Map(FinalsStages(), CreateGroups(_333bf-r3, 1, 2026-07-19T14:50, 2026-07-19T15:15))
Map(FinalsStages(), CreateGroups(_pyram-r3, 1, 2026-07-19T15:15, 2026-07-19T15:40))
Map(FinalsStages(), CreateGroups(_sq1-r3,   1, 2026-07-19T15:40, 2026-07-19T16:05))

CreateGroups(_333-r4, 0, ORANGE, 2026-07-19T16:15, 2026-07-19T17:40)

# Misc
CreateMiscActivity("Check-in",                                 "other-checkin", HALL123,  2026-07-16T08:00, 2026-07-16T09:00)
CreateMiscActivity("Check-in",                                 "other-checkin", HALL123,  2026-07-17T08:00, 2026-07-17T09:00)
CreateMiscActivity("Check-in",                                 "other-checkin", HALL123,  2026-07-18T08:00, 2026-07-18T09:00)
CreateMiscActivity("Venue Opens",                              "other-checkin", HALL123,  2026-07-19T09:00, 2026-07-19T10:00)
CreateMiscActivity("Lunch",                                    "other-lunch",   HALL123,  2026-07-16T12:15, 2026-07-16T13:15)
CreateMiscActivity("Lunch",                                    "other-lunch",   HALL123,  2026-07-17T12:20, 2026-07-17T13:20)
CreateMiscActivity("Lunch",                                    "other-lunch",   HALL123,  2026-07-18T12:35, 2026-07-18T13:35)
CreateMiscActivity("Lunch",                                    "other-lunch",   HALL123,  2026-07-19T13:25, 2026-07-19T14:25)
CreateMiscActivity("Dinner",                                   "other-dinner",  HALL123,  2026-07-16T18:50, 2026-07-16T19:20)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind A1", "other-multi",   SIDEROOM, 2026-07-16T13:40, 2026-07-16T14:10)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind A2", "other-multi",   SIDEROOM, 2026-07-17T13:20, 2026-07-17T13:50)
CreateMiscActivity("Opening Ceremony",                         "other-awards",  HALL123,  2026-07-16T12:45, 2026-07-16T13:30)
CreateMiscActivity("Rubik's Nations Cup",                      "other-awards",  HALL123,  2026-07-16T19:20, 2026-07-16T20:50)
CreateMiscActivity("Awards",                                   "other-awards",  HALL123,  2026-07-19T17:50, 2026-07-19T18:50)