#include "../lib/_constants.cs"

CreateRoom(PISTA, "#006633")
CreateRoom(BARRA, "#4b4b4b")

CreateStage(GREEN, PISTA, "#006633")
CreateStage(WHITE, PISTA, "#ffffff")

# Saturday
CreateGroups(_777-r1, 2, GREEN, 2026-03-07T09:00, 2026-03-07T10:00)
CreateGroups(_666-r1, 2, GREEN, 2026-03-07T10:00, 2026-03-07T10:55)
Map(Stages(), CreateGroups(_444-r1, 2, 2026-03-07T10:55, 2026-03-07T11:45))
Map(Stages(), CreateGroups(_pyram-r1, 2, 2026-03-07T11:45, 2026-03-07T12:20))
CreateGroups(_sq1-r1, 2, GREEN, 2026-03-07T12:20, 2026-03-07T13:05)
Map(Stages(), CreateGroups(_skewb-r1, 2, 2026-03-07T13:05, 2026-03-07T13:40))
Map(Stages(), CreateGroups(_333-r1, 3, 2026-03-07T15:10, 2026-03-07T16:20))
Map(Stages(), CreateGroups(_222-r1, 3, 2026-03-07T16:20, 2026-03-07T17:15))
Map(Stages(), CreateGroups(_333oh-r1, 2, 2026-03-07T17:15, 2026-03-07T18:00))
CreateGroups(_333bf-r1, 2, GREEN, 2026-03-07T18:00, 2026-03-07T18:45)
Map(Stages(), CreateGroups(_minx-r1, 2, 2026-03-07T18:45, 2026-03-07T19:35))

# Sunday
Map(Stages(), CreateGroups(_clock-r1, 2, 2026-03-08T09:00, 2026-03-08T09:45))
CreateGroups(_555-r1, 2, GREEN, 2026-03-08T09:45, 2026-03-08T10:40)
Map(Stages(), CreateGroups(_333-r2, 2, 2026-03-08T10:40, 2026-03-08T11:25))
CreateGroups(_sq1-r2, 1, GREEN, 2026-03-08T11:25, 2026-03-08T11:45)
CreateGroups(_skewb-r2, 1, GREEN, 2026-03-08T11:45, 2026-03-08T12:05)
CreateGroups(_pyram-r2, 1, GREEN, 2026-03-08T12:05, 2026-03-08T12:25)
CreateGroups(_minx-r2, 1, GREEN, 2026-03-08T12:25, 2026-03-08T12:45)
CreateGroups(_clock-r2, 1, GREEN, 2026-03-08T12:45, 2026-03-08T13:05)
CreateGroups(_333oh-r2, 1, GREEN, 2026-03-08T13:05, 2026-03-08T13:25)
CreateGroups(_333bf-r2, 1, GREEN, 2026-03-08T13:25, 2026-03-08T13:45)
CreateGroups(_555-r2, 1, GREEN, 2026-03-08T15:15, 2026-03-08T15:40)
CreateGroups(_444-r2, 1, GREEN, 2026-03-08T15:40, 2026-03-08T16:00)
CreateGroups(_222-r2, 1, GREEN, 2026-03-08T16:00, 2026-03-08T16:20)
CreateGroups(_333-r3, 1, GREEN, 2026-03-08T16:20, 2026-03-08T16:40)

# Misc
CreateMiscActivity("Check-in", "other-checkin", PISTA, 2026-03-07T08:30, 2026-03-07T09:00)
CreateMiscActivity("Check-in", "other-checkin", PISTA, 2026-03-08T08:30, 2026-03-08T09:00)
CreateMiscActivity("Lunch", "other-lunch", BARRA, 2026-03-07T13:40, 2026-03-07T15:10)
CreateMiscActivity("Lunch", "other-lunch", BARRA, 2026-03-08T13:45, 2026-03-08T15:15)
CreateMiscActivity("Copa de Andalucía", "other-misc", PISTA, 2026-03-07T19:35, 2026-03-07T21:00)
CreateMiscActivity("Awards", "other-awards", PISTA, 2026-03-08T16:40, 2026-03-08T17:10)