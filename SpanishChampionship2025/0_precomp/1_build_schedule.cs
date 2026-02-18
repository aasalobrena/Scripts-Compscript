#include "../lib/_constants.cs"

CreateRoom(PALAU, "#808080")
CreateRoom(MAIN, "#c00707")
CreateRoom(GREEN, "#459834")
CreateRoom(AUX, "#000000")

CreateStage(RED, MAIN, "#c00707", groupNamePrefix="Escenario rojo")
CreateStage(YELLOW, MAIN, "#eeff00", groupNamePrefix="Escenario amarillo")

# Aux
CreateGroups(_333mbf-r1-a1, 1, AUX, 2025-12-06T15:00, 2025-12-06T16:15, useStageName=false)
CreateGroups(_333mbf-r1-a2, 1, AUX, 2025-12-07T10:15, 2025-12-07T11:30, useStageName=false)
CreateGroups(_444bf-r1, 1, AUX, 2025-12-06T09:35, 2025-12-06T10:20, useStageName=false)
CreateGroups(_555bf-r1, 1, AUX, 2025-12-07T14:55, 2025-12-07T15:55, useStageName=false)

# Saturday
Map(MainStages(), CreateGroups(_777-r1, 2, 2025-12-06T09:00, 2025-12-06T10:00))
CreateGroups(_777-r1, 1, GREEN, 2025-12-06T09:00, 2025-12-06T09:30)

Map(MainStages(), CreateGroups(_clock-r1, 3, 2025-12-06T10:00, 2025-12-06T10:45, [1],
                               extraMinutesByGroup=[Tuple(2, 22.5),
                                                    Tuple(3, 22.5)]))
CreateGroups(_clock-r1, 4, GREEN, 2025-12-06T09:30, 2025-12-06T11:10,
             extraMinutesByGroup=[Tuple(1, 7.5),
                                  Tuple(4, 2.5)])

Map(MainStages(), CreateGroups(_666-r1, 2, 2025-12-06T10:45, 2025-12-06T11:40,
                               extraMinutesByGroup=[Tuple(2, 5)]))
CreateGroups(_666-r1, 2, GREEN, 2025-12-06T11:10, 2025-12-06T11:40, [1],
             extraMinutesByGroup=[Tuple(2, 30)])

Map(AllStages(), CreateGroups(_333oh-r1, 3, 2025-12-06T11:40, 2025-12-06T12:50))
Map(AllStages(), CreateGroups(_sq1-r1, 2, 2025-12-06T12:50, 2025-12-06T13:30))

Map(MainStages(), CreateGroups(_minx-r1, 2, 2025-12-06T14:30, 2025-12-06T15:20))
CreateGroups(_minx-r1, 3, GREEN, 2025-12-06T14:30, 2025-12-06T15:50,
             extraMinutesByGroup=[Tuple(3, 5)])

Map(MainStages(), CreateGroups(_555-r1, 3, 2025-12-06T15:20, 2025-12-06T16:50))
CreateGroups(_555-r1, 3, GREEN, 2025-12-06T15:50, 2025-12-06T16:50, [1],
             extraMinutesByGroup=[Tuple(2, 30),
                                  Tuple(3, 30)])

Map(AllStages(), CreateGroups(_333bf-r1, 2, 2025-12-06T16:50, 2025-12-06T17:30))
Map(MainStages(), CreateGroups(_clock-r2, 2, 2025-12-06T17:30, 2025-12-06T18:15))
Map(MainStages(), CreateGroups(_sq1-r2, 2, 2025-12-06T18:15, 2025-12-06T18:55))
Map(MainStages(), CreateGroups(_minx-r2, 2, 2025-12-06T18:55, 2025-12-06T19:45))
Map(MainStages(), CreateGroups(_777-r2, 1, 2025-12-06T19:45, 2025-12-06T20:10))
Map(MainStages(), CreateGroups(_666-r2, 1, 2025-12-06T20:10, 2025-12-06T20:30))

# Sunday
Map(AllStages(), CreateGroups(_222-r1, 4, 2025-12-07T09:00, 2025-12-07T10:15))
Map(AllStages(), CreateGroups(_333-r1, 5, 2025-12-07T10:15, 2025-12-07T12:05))
Map(AllStages(), CreateGroups(_pyram-r1, 4, 2025-12-07T12:05, 2025-12-07T13:15))

Map(MainStages(), CreateGroups(_skewb-r1, 3, 2025-12-07T14:15, 2025-12-07T15:10))
CreateGroups(_skewb-r1, 4, GREEN, 2025-12-07T14:15, 2025-12-07T15:35,
             extraMinutesByGroup=[Tuple(4, (20 / 3))])

Map(MainStages(), CreateGroups(_444-r1, 4, 2025-12-07T15:10, 2025-12-07T16:50))
CreateGroups(_444-r1, 4, GREEN, 2025-12-07T15:35, 2025-12-07T16:50, [1],
             extraMinutesByGroup=[Tuple(2, 25),
                                  Tuple(3, 25),
                                  Tuple(4, 25)])

Map(AllStages(), CreateGroups(_333-r2, 3, 2025-12-07T16:50, 2025-12-07T18:00))
Map(AllStages(), CreateGroups(_222-r2, 2, 2025-12-07T18:00, 2025-12-07T18:40))
Map(AllStages(), CreateGroups(_333oh-r2, 1, 2025-12-07T18:40, 2025-12-07T19:05))
Map(MainStages(), CreateGroups(_333bf-r2, 1, 2025-12-07T19:05, 2025-12-07T19:25))

# Monday
Map(AllStages(), CreateGroups(_pyram-r2, 2, 2025-12-08T09:00, 2025-12-08T09:35))
Map(AllStages(), CreateGroups(_skewb-r2, 2, 2025-12-08T09:35, 2025-12-08T10:10))
Map(AllStages(), CreateGroups(_444-r2, 2, 2025-12-08T10:10, 2025-12-08T11:00))
Map(AllStages(), CreateGroups(_333-r3, 1, 2025-12-08T11:00, 2025-12-08T11:25))
Map(MainStages(), CreateGroups(_sq1-r3, 1, 2025-12-08T11:25, 2025-12-08T11:45))
Map(MainStages(), CreateGroups(_333oh-r3, 1, 2025-12-08T11:45, 2025-12-08T12:05))
Map(MainStages(), CreateGroups(_minx-r3, 1, 2025-12-08T12:05, 2025-12-08T12:25))
Map(MainStages(), CreateGroups(_clock-r3, 1, 2025-12-08T12:25, 2025-12-08T12:45))
Map(MainStages(), CreateGroups(_555-r2, 1, 2025-12-08T12:45, 2025-12-08T13:05))
Map(MainStages(), CreateGroups(_444-r3, 1, 2025-12-08T13:05, 2025-12-08T13:25))
Map(MainStages(), CreateGroups(_333bf-r3, 1, 2025-12-08T14:25, 2025-12-08T14:45))
Map(MainStages(), CreateGroups(_skewb-r3, 1, 2025-12-08T14:45, 2025-12-08T15:05))
Map(MainStages(), CreateGroups(_pyram-r3, 1, 2025-12-08T15:05, 2025-12-08T15:25))
Map(MainStages(), CreateGroups(_222-r3, 1, 2025-12-08T15:25, 2025-12-08T15:45))

CreateGroups(_333-r4, 1, YELLOW, 2025-12-08T15:45, 2025-12-08T16:05)
Map(MainStages(), CreateGroups(_333-r4, 8, 2025-12-08T16:05, 2025-12-08T17:15, [1],
                               extraMinutesByGroup=[Tuple(2, 10),
                                                    Tuple(3, 10),
                                                    Tuple(4, 10),
                                                    Tuple(5, 10),
                                                    Tuple(6, 10),
                                                    Tuple(7, 10),
                                                    Tuple(8, 10)]))

# Misc
CreateMiscActivity("Check-in", "other-checkin", PALAU, 2025-12-06T08:30, 2025-12-06T09:00)
CreateMiscActivity("Check-in", "other-checkin", PALAU, 2025-12-07T08:30, 2025-12-07T09:00)
CreateMiscActivity("Doors open", "other-checkin", PALAU, 2025-12-08T08:30, 2025-12-08T09:00)
CreateMiscActivity("Lunch", "other-lunch", PALAU, 2025-12-06T13:30, 2025-12-06T14:30)
CreateMiscActivity("Lunch", "other-lunch", PALAU, 2025-12-07T13:15, 2025-12-07T14:15)
CreateMiscActivity("Lunch", "other-lunch", PALAU, 2025-12-08T13:25, 2025-12-08T14:25)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind A1", "other-multi", AUX, 2025-12-06T12:20, 2025-12-06T12:50)
CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind A2", "other-multi", AUX, 2025-12-07T08:30, 2025-12-07T09:00)
CreateMiscActivity("Copa de España", "other-misc", MAIN, 2025-12-07T19:25, 2025-12-07T20:30)
CreateMiscActivity("Awards", "other-awards", MAIN, 2025-12-08T17:15, 2025-12-08T18:30)