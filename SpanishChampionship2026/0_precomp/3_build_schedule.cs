#include "../lib/_constants.cs"

CreateRoom(MAIN_ROOM, "#fb1313")
CreateRoom(SIDE_ROOM, "#681da8")

CreateStage(ARABA_STAGE,    MAIN_ROOM, "#F39200")
CreateStage(BIZKAIA_STAGE,  MAIN_ROOM, "#008B3B")
CreateStage(GIPUZKOA_STAGE, MAIN_ROOM, "#25346C")

# Side Room
CreateGroups(_444bf-r1, 1,     SIDE_ROOM, 2026-12-05T09:40, 2026-12-05T10:25, useStageName=false)
CreateGroups(_555bf-r1, 1,     SIDE_ROOM, 2026-12-06T15:15, 2026-12-06T16:15, useStageName=false)
CreateGroups(_333mbf-r1-a1, 1, SIDE_ROOM, 2026-12-05T15:15, 2026-12-05T16:25, useStageName=false)
CreateGroups(_333mbf-r1-a2, 1, SIDE_ROOM, 2026-12-06T11:05, 2026-12-06T12:15, useStageName=false)

# Saturday
Map(AllStages(),    CreateGroups(_clock-r1, 3, 2026-12-05T09:00, 2026-12-05T10:00))
Map(AllStages(),    CreateGroups(_777-r1,   2, 2026-12-05T10:00, 2026-12-05T10:55))
Map(AllStages(),    CreateGroups(_sq1-r1,   2, 2026-12-05T10:55, 2026-12-05T11:40))
Map(AllStages(),    CreateGroups(_666-r1,   2, 2026-12-05T11:40, 2026-12-05T12:35))
Map(AllStages(),    CreateGroups(_333bf-r1, 2, 2026-12-05T12:35, 2026-12-05T13:15))
Map(AllStages(),    CreateGroups(_555-r1,   2, 2026-12-05T14:50, 2026-12-05T15:55))
Map(AllStages(),    CreateGroups(_minx-r1,  2, 2026-12-05T15:55, 2026-12-05T16:55))
Map(FinalsStages(), CreateGroups(_333bf-r2, 1, 2026-12-05T16:55, 2026-12-05T17:15))
Map(FinalsStages(), CreateGroups(_777-r2,   1, 2026-12-05T17:15, 2026-12-05T17:40))
Map(FinalsStages(), CreateGroups(_clock-r2, 1, 2026-12-05T17:40, 2026-12-05T18:05))
Map(FinalsStages(), CreateGroups(_555-r2,   1, 2026-12-05T18:05, 2026-12-05T18:30))
Map(FinalsStages(), CreateGroups(_sq1-r2,   1, 2026-12-05T18:30, 2026-12-05T18:55))

# Sunday
Map(AllStages(),    CreateGroups(_pyram-r1, 3, 2026-12-06T09:15, 2026-12-06T10:10))
Map(AllStages(),    CreateGroups(_444-r1,   4, 2026-12-06T10:10, 2026-12-06T11:50))
Map(AllStages(),    CreateGroups(_222-r1,   4, 2026-12-06T11:50, 2026-12-06T13:05))
Map(AllStages(),    CreateGroups(_skewb-r1, 3, 2026-12-06T14:35, 2026-12-06T15:30))
Map(AllStages(),    CreateGroups(_333-r1,   4, 2026-12-06T15:30, 2026-12-06T17:00))
Map(AllStages(),    CreateGroups(_pyram-r2, 2, 2026-12-06T17:00, 2026-12-06T17:40))
Map(AllStages(),    CreateGroups(_333oh-r1, 3, 2026-12-06T17:40, 2026-12-06T18:50))
Map(FinalsStages(), CreateGroups(_minx-r2,  1, 2026-12-06T18:50, 2026-12-06T19:15))
Map(FinalsStages(), CreateGroups(_333bf-r3, 1, 2026-12-06T19:15, 2026-12-06T19:35))
Map(FinalsStages(), CreateGroups(_666-r2,   1, 2026-12-06T19:35, 2026-12-06T20:00))

# Monday
Map(AllStages(),    CreateGroups(_333-r2,   3, 2026-12-07T09:05, 2026-12-07T10:15))
Map(AllStages(),    CreateGroups(_444-r2,   2, 2026-12-07T10:15, 2026-12-07T11:05))
Map(AllStages(),    CreateGroups(_222-r2,   2, 2026-12-07T11:05, 2026-12-07T11:45))
Map(AllStages(),    CreateGroups(_333oh-r2, 2, 2026-12-07T11:45, 2026-12-07T12:20))
Map(AllStages(),    CreateGroups(_skewb-r2, 2, 2026-12-07T12:20, 2026-12-07T12:55))
Map(AllStages(),    CreateGroups(_333-r3,   2, 2026-12-07T12:55, 2026-12-07T13:15))
Map(FinalsStages(), CreateGroups(_skewb-r3, 1, 2026-12-07T14:45, 2026-12-07T15:05))
Map(FinalsStages(), CreateGroups(_333oh-r3, 1, 2026-12-07T15:05, 2026-12-07T15:30))
Map(FinalsStages(), CreateGroups(_pyram-r3, 1, 2026-12-07T15:30, 2026-12-07T15:50))
Map(FinalsStages(), CreateGroups(_444-r3,   1, 2026-12-07T15:50, 2026-12-07T16:15))
Map(FinalsStages(), CreateGroups(_222-r3,   1, 2026-12-07T16:15, 2026-12-07T16:35))
CreateGroups(_333-r4, 1, GIPUZKOA_STAGE, 2026-12-07T16:50, 2026-12-07T17:10)
Map(FinalsStages(), CreateGroups(_333-r4, 7, 2026-12-07T17:10, 2026-12-07T18:10, [1],
                                 extraMinutesByGroup=[Tuple(2, 10),
                                                      Tuple(3, 10),
                                                      Tuple(4, 10),
                                                      Tuple(5, 10),
                                                      Tuple(6, 10),
                                                      Tuple(7, 10)
                                                     ]
                                )
   )

# Misc
CreateMiscActivity("Registro",   "other-checkin", MAIN_ROOM, 2026-12-05T08:30, 2026-12-05T09:00)
CreateMiscActivity("Registro",   "other-checkin", MAIN_ROOM, 2026-12-06T08:45, 2026-12-06T09:15)
CreateMiscActivity("Doors open", "other-checkin", MAIN_ROOM, 2026-12-07T08:45, 2026-12-07T09:05)
CreateMiscActivity("Comida", "other-lunch", MAIN_ROOM, 2026-12-05T13:20, 2026-12-05T14:50)
CreateMiscActivity("Comida", "other-lunch", MAIN_ROOM, 2026-12-06T13:05, 2026-12-06T14:35)
CreateMiscActivity("Comida", "other-lunch", MAIN_ROOM, 2026-12-07T13:15, 2026-12-07T14:45)
CreateMiscActivity("Cube submission for 3x3x3 Multi-Blind A1", "other-multi", SIDE_ROOM, 2026-12-05T13:15, 2026-12-05T13:35)
CreateMiscActivity("Cube submission for 3x3x3 Multi-Blind A2", "other-multi", SIDE_ROOM, 2026-12-06T08:55, 2026-12-06T09:15)
CreateMiscActivity("Montaje Copa de España", "other-setup", MAIN_ROOM, 2026-12-05T18:55, 2026-12-05T19:10)
CreateMiscActivity("Montaje",                "other-setup", MAIN_ROOM, 2026-12-07T16:35, 2026-12-07T16:50)
CreateMiscActivity("Entrega de premios", "other-awards", MAIN_ROOM, 2026-12-07T18:10, 2026-12-07T19:10)
CreateMiscActivity("Puzzles: Individual 500 piezas", "other-misc", MAIN_ROOM, 2026-12-05T11:30, 2026-12-05T13:30)
CreateMiscActivity("Puzzles: Parejas 500 piezas",    "other-misc", MAIN_ROOM, 2026-12-05T16:30, 2026-12-05T18:30)
CreateMiscActivity("Copa de España",                 "other-misc", MAIN_ROOM, 2026-12-05T19:10, 2026-12-05T20:30)