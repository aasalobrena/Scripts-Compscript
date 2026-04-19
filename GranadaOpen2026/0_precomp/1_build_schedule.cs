#include "../lib/_constants.cs"

CreateRoom(SALON, "#981932")
CreateRoom(AUX, "#078930")

# Misc
CreateMiscActivity("Check-in", "other-checkin", SALON, 2026-04-25T08:30, 2026-04-25T09:00)
CreateMiscActivity("Tutorial nuevos competidores", "other-tutorial", SALON, 2026-04-25T08:45, 2026-04-25T09:00)
CreateMiscActivity("Entrega MBLD", "other-multi", AUX, 2026-04-25T13:45, 2026-04-25T14:00)
CreateMiscActivity("Comida", "other-lunch", SALON, 2026-04-25T13:45, 2026-04-25T15:10)
CreateMiscActivity("Desmontaje", "other-teardown", SALON, 2026-04-26T13:15, 2026-04-26T13:30)
CreateMiscActivity("Premios", "other-awards", SALON, 2026-04-26T13:30, 2026-04-26T14:00)

# Saturday
CreateGroups(_pyram-r1, 4, SALON, 2026-04-25T09:00, 2026-04-25T10:00, useStageName=false)
CreateGroups(_444-r1, 3, SALON, 2026-04-25T10:00, 2026-04-25T11:15, useStageName=false)
CreateGroups(_sq1-r1, 2, SALON, 2026-04-25T11:15, 2026-04-25T12:00, useStageName=false)
CreateGroups(_333bf-r1, 2, SALON, 2026-04-25T12:00, 2026-04-25T12:45, useStageName=false)
CreateGroups(_clock-r1, 3, SALON, 2026-04-25T12:45, 2026-04-25T13:45, useStageName=false)
CreateGroups(_222-r1, 5, SALON, 2026-04-25T15:10, 2026-04-25T16:40, useStageName=false)
CreateGroups(_333mbf-r1-a1, 1, AUX, 2026-04-25T15:55, 2026-04-25T17:05, useStageName=false)
CreateGroups(_333-r1, 5, SALON, 2026-04-25T16:40, 2026-04-25T18:10, useStageName=false)
CreateGroups(_skewb-r1, 3, SALON, 2026-04-25T18:10, 2026-04-25T19:10, useStageName=false)
CreateGroups(_pyram-r2, 2, SALON, 2026-04-25T19:10, 2026-04-25T19:40, useStageName=false)
CreateGroups(_444-r2, 2, SALON, 2026-04-25T19:40, 2026-04-25T20:35, useStageName=false)

# Sunday
CreateGroups(_333-r2, 2, SALON, 2026-04-26T09:00, 2026-04-26T09:40, useStageName=false)
CreateGroups(_222-r2, 3, SALON, 2026-04-26T09:40, 2026-04-26T10:25, useStageName=false)
CreateGroups(_skewb-r2, 1, SALON, 2026-04-26T10:25, 2026-04-26T10:45, useStageName=false)
CreateGroups(_clock-r2, 1, SALON, 2026-04-26T10:45, 2026-04-26T11:05, useStageName=false)
CreateGroups(_333bf-r2, 1, SALON, 2026-04-26T11:05, 2026-04-26T11:30, useStageName=false)
CreateGroups(_sq1-r2, 1, SALON, 2026-04-26T11:30, 2026-04-26T11:50, useStageName=false)
CreateGroups(_444-r3, 1, SALON, 2026-04-26T11:50, 2026-04-26T12:15, useStageName=false)
CreateGroups(_pyram-r3, 1, SALON, 2026-04-26T12:15, 2026-04-26T12:35, useStageName=false)
CreateGroups(_333-r3, 1, SALON, 2026-04-26T12:35, 2026-04-26T12:55, useStageName=false)
CreateGroups(_222-r3, 1, SALON, 2026-04-26T12:55, 2026-04-26T13:15, useStageName=false)