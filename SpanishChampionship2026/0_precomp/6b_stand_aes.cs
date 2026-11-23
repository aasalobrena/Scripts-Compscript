#include "../lib/_constants.cs"

# Stand de la AES: tareas por grupo del Pabellón, según «Tareas Stand Nacional.xlsx».
# Ejecutar UNA sola vez, después de 6_assign_main y antes de 7_assign_main_volunteers (y del staff de 4_assign_side),
# sobre el WCIF con los grupos de competidor ya generados. 6a (casters) va antes que 6b (stand AES).
# El equipo AES no está en los grupos de voluntarios, así que no recibe staff y no necesita indisponibilidades.

# 1. Cambios de grupo. Van PRIMERO: ManuallyAssign de competidor borra todas las asignaciones
#    de esa persona en los grupos de esa ronda.
ManuallyAssign([2022BAGU01], _777-r1, GIPUZKOA_STAGE, 2)  # Irene Rábago: Gipuzkoa g1 -> g2
ManuallyAssign([2022BAGU01], _666-r1, GIPUZKOA_STAGE, 2)  # Irene Rábago: Gipuzkoa g1 -> g2
ManuallyAssign([2022MENE02], _555-r1, GIPUZKOA_STAGE, 2)  # Irene Fraile: Gipuzkoa g1 -> g2
ManuallyAssign([2019TORR29], _555-r1, GIPUZKOA_STAGE, 1)  # Marc Serra: Gipuzkoa g2 -> g1
ManuallyAssign([2019TORR29], _minx-r1, BIZKAIA_STAGE, 2)  # Marc Serra: Bizkaia g1 -> g2
ManuallyAssign([2018FRAN17], _222-r1, GIPUZKOA_STAGE, 3)  # María Ángeles: Gipuzkoa g1 -> g3
ManuallyAssign([2018MOLI03], _222-r1, GIPUZKOA_STAGE, 3)  # Francisco Huertas: Gipuzkoa g4 -> g3
ManuallyAssign([2019TORR29], _222-r1, GIPUZKOA_STAGE, 2)  # Marc Serra: Gipuzkoa g3 -> g2
ManuallyAssign([2019TORR29], _333oh-r1, GIPUZKOA_STAGE, 3)  # Marc Serra: Gipuzkoa g2 -> g3

# 2. Tareas
# clock-r1
ManuallyAssign([2022MENE02, 2022BAGU01, 2018FRAN17, 2023AZUR01, 2019TORR29], _clock-r1, MAIN_ROOM, 1, REGISTRO)  # Irene Fraile, Irene Rábago, María Ángeles, Jaione Bengoetxea, Marc Serra, sáb 09:00
ManuallyAssign([2022MENE02, 2022BAGU01, 2018FRAN17, 2023AZUR01, 2018MOLI03], _clock-r1, MAIN_ROOM, 2, REGISTRO)  # Irene Fraile, Irene Rábago, María Ángeles, Jaione Bengoetxea, Francisco Huertas, sáb 09:30

# 777-r1
ManuallyAssign([2022BAGU01], _777-r1, MAIN_ROOM, 1, CAYRO)  # Irene Rábago, sáb 10:00
ManuallyAssign([2018FRAN17], _777-r1, MAIN_ROOM, 1, STAND)  # María Ángeles, sáb 10:00
ManuallyAssign([2018MOLI03, 2019TORR29], _777-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Francisco Huertas, Marc Serra, sáb 10:00
ManuallyAssign([2022MENE02], _777-r1, MAIN_ROOM, 2, STAND)  # Irene Fraile, sáb 10:27
ManuallyAssign([2023AZUR01, 2018MOLI03], _777-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Francisco Huertas, sáb 10:27

# sq1-r1
ManuallyAssign([2022BAGU01], _sq1-r1, MAIN_ROOM, 1, STAND)  # Irene Rábago, sáb 10:55
ManuallyAssign([2023AZUR01, 2019TORR29], _sq1-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, sáb 10:55
ManuallyAssign([2022MENE02], _sq1-r1, MAIN_ROOM, 2, CAYRO)  # Irene Fraile, sáb 11:17
ManuallyAssign([2018FRAN17], _sq1-r1, MAIN_ROOM, 2, STAND)  # María Ángeles, sáb 11:17
ManuallyAssign([2023AZUR01, 2018MOLI03], _sq1-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Francisco Huertas, sáb 11:17

# 666-r1
ManuallyAssign([2022BAGU01], _666-r1, MAIN_ROOM, 1, CAYRO)  # Irene Rábago, sáb 11:40
ManuallyAssign([2018FRAN17], _666-r1, MAIN_ROOM, 1, STAND)  # María Ángeles, sáb 11:40
ManuallyAssign([2018MOLI03, 2019TORR29], _666-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Francisco Huertas, Marc Serra, sáb 11:40
ManuallyAssign([2018FRAN17], _666-r1, MAIN_ROOM, 2, CAYRO)  # María Ángeles, sáb 12:07
ManuallyAssign([2022MENE02], _666-r1, MAIN_ROOM, 2, STAND)  # Irene Fraile, sáb 12:07
ManuallyAssign([2023AZUR01, 2018MOLI03], _666-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Francisco Huertas, sáb 12:07

# 333bf-r1
ManuallyAssign([2022MENE02], _333bf-r1, MAIN_ROOM, 1, CAYRO)  # Irene Fraile, sáb 12:35
ManuallyAssign([2022BAGU01], _333bf-r1, MAIN_ROOM, 1, STAND)  # Irene Rábago, sáb 12:35
ManuallyAssign([2018MOLI03, 2019TORR29], _333bf-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Francisco Huertas, Marc Serra, sáb 12:35
ManuallyAssign([2022MENE02], _333bf-r1, MAIN_ROOM, 2, CAYRO)  # Irene Fraile, sáb 12:55
ManuallyAssign([2022BAGU01], _333bf-r1, MAIN_ROOM, 2, STAND)  # Irene Rábago, sáb 12:55
ManuallyAssign([2023AZUR01, 2019TORR29], _333bf-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, sáb 12:55

# 555-r1
ManuallyAssign([2022MENE02], _555-r1, MAIN_ROOM, 1, STAND)  # Irene Fraile, sáb 14:50
ManuallyAssign([2018MOLI03], _555-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Francisco Huertas, sáb 14:50
ManuallyAssign([2022BAGU01], _555-r1, MAIN_ROOM, 2, CAYRO)  # Irene Rábago, sáb 15:15
ManuallyAssign([2018FRAN17], _555-r1, MAIN_ROOM, 2, STAND)  # María Ángeles, sáb 15:15
ManuallyAssign([2023AZUR01, 2019TORR29], _555-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, sáb 15:15

# minx-r1
ManuallyAssign([2022BAGU01], _minx-r1, MAIN_ROOM, 1, CAYRO)  # Irene Rábago, sáb 15:55
ManuallyAssign([2018FRAN17], _minx-r1, MAIN_ROOM, 1, STAND)  # María Ángeles, sáb 15:55
ManuallyAssign([2023AZUR01, 2019TORR29], _minx-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, sáb 15:55
ManuallyAssign([2018FRAN17], _minx-r1, MAIN_ROOM, 2, CAYRO)  # María Ángeles, sáb 16:25
ManuallyAssign([2022MENE02], _minx-r1, MAIN_ROOM, 2, STAND)  # Irene Fraile, sáb 16:25
ManuallyAssign([2018MOLI03], _minx-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Francisco Huertas, sáb 16:25

# pyram-r1
ManuallyAssign([2022MENE02, 2022BAGU01, 2018FRAN17, 2019TORR29], _pyram-r1, MAIN_ROOM, 1, REGISTRO)  # Irene Fraile, Irene Rábago, María Ángeles, Marc Serra, dom 09:15
ManuallyAssign([2018FRAN17, 2023AZUR01, 2018MOLI03, 2019TORR29], _pyram-r1, MAIN_ROOM, 2, REGISTRO)  # María Ángeles, Jaione Bengoetxea, Francisco Huertas, Marc Serra, dom 09:33
ManuallyAssign([2022MENE02, 2022BAGU01, 2018FRAN17, 2023AZUR01, 2018MOLI03], _pyram-r1, MAIN_ROOM, 3, REGISTRO)  # Irene Fraile, Irene Rábago, María Ángeles, Jaione Bengoetxea, Francisco Huertas, dom 09:51

# 444-r1
ManuallyAssign([2022MENE02], _444-r1, MAIN_ROOM, 1, CAYRO)  # Irene Fraile, dom 10:10
ManuallyAssign([2018FRAN17], _444-r1, MAIN_ROOM, 1, REGISTRO)  # María Ángeles, dom 10:10
ManuallyAssign([2022BAGU01], _444-r1, MAIN_ROOM, 1, STAND)  # Irene Rábago, dom 10:10
ManuallyAssign([2019TORR29], _444-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Marc Serra, dom 10:10
ManuallyAssign([2018FRAN17], _444-r1, MAIN_ROOM, 2, CAYRO)  # María Ángeles, dom 10:35
ManuallyAssign([2018MOLI03], _444-r1, MAIN_ROOM, 2, REGISTRO)  # Francisco Huertas, dom 10:35
ManuallyAssign([2022BAGU01], _444-r1, MAIN_ROOM, 2, STAND)  # Irene Rábago, dom 10:35
ManuallyAssign([2018FRAN17], _444-r1, MAIN_ROOM, 3, CAYRO)  # María Ángeles, dom 11:00
ManuallyAssign([2018MOLI03], _444-r1, MAIN_ROOM, 3, REGISTRO)  # Francisco Huertas, dom 11:00
ManuallyAssign([2022MENE02], _444-r1, MAIN_ROOM, 3, STAND)  # Irene Fraile, dom 11:00
ManuallyAssign([2023AZUR01, 2019TORR29], _444-r1, MAIN_ROOM, 3, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, dom 11:00
ManuallyAssign([2022BAGU01], _444-r1, MAIN_ROOM, 4, CAYRO)  # Irene Rábago, dom 11:25
ManuallyAssign([2022MENE02], _444-r1, MAIN_ROOM, 4, STAND)  # Irene Fraile, dom 11:25
ManuallyAssign([2018MOLI03], _444-r1, MAIN_ROOM, 4, UNOFFICIAL)  # Francisco Huertas, dom 11:25

# 222-r1
ManuallyAssign([2022BAGU01], _222-r1, MAIN_ROOM, 1, CAYRO)  # Irene Rábago, dom 11:50
ManuallyAssign([2023AZUR01], _222-r1, MAIN_ROOM, 1, REGISTRO)  # Jaione Bengoetxea, dom 11:50
ManuallyAssign([2018FRAN17], _222-r1, MAIN_ROOM, 1, STAND)  # María Ángeles, dom 11:50
ManuallyAssign([2018MOLI03], _222-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Francisco Huertas, dom 11:50
ManuallyAssign([2022MENE02], _222-r1, MAIN_ROOM, 2, CAYRO)  # Irene Fraile, dom 12:08
ManuallyAssign([2018FRAN17], _222-r1, MAIN_ROOM, 2, STAND)  # María Ángeles, dom 12:08
ManuallyAssign([2018MOLI03], _222-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Francisco Huertas, dom 12:08
ManuallyAssign([2022BAGU01], _222-r1, MAIN_ROOM, 3, STAND)  # Irene Rábago, dom 12:27
ManuallyAssign([2019TORR29], _222-r1, MAIN_ROOM, 3, UNOFFICIAL)  # Marc Serra, dom 12:27
ManuallyAssign([2018FRAN17, 2018MOLI03], _222-r1, MAIN_ROOM, 4, CAYRO)  # María Ángeles, Francisco Huertas, dom 12:46
ManuallyAssign([2022BAGU01], _222-r1, MAIN_ROOM, 4, STAND)  # Irene Rábago, dom 12:46
ManuallyAssign([2023AZUR01], _222-r1, MAIN_ROOM, 4, UNOFFICIAL)  # Jaione Bengoetxea, dom 12:46

# skewb-r1
ManuallyAssign([2022BAGU01], _skewb-r1, MAIN_ROOM, 1, CAYRO)  # Irene Rábago, dom 14:35
ManuallyAssign([2018MOLI03], _skewb-r1, MAIN_ROOM, 1, REGISTRO)  # Francisco Huertas, dom 14:35
ManuallyAssign([2022MENE02], _skewb-r1, MAIN_ROOM, 1, STAND)  # Irene Fraile, dom 14:35
ManuallyAssign([2019TORR29], _skewb-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Marc Serra, dom 14:35
ManuallyAssign([2018FRAN17], _skewb-r1, MAIN_ROOM, 2, CAYRO)  # María Ángeles, dom 14:53
ManuallyAssign([2022MENE02], _skewb-r1, MAIN_ROOM, 2, STAND)  # Irene Fraile, dom 14:53
ManuallyAssign([2023AZUR01], _skewb-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, dom 14:53
ManuallyAssign([2018FRAN17], _skewb-r1, MAIN_ROOM, 3, CAYRO)  # María Ángeles, dom 15:11
ManuallyAssign([2023AZUR01], _skewb-r1, MAIN_ROOM, 3, REGISTRO)  # Jaione Bengoetxea, dom 15:11
ManuallyAssign([2022BAGU01], _skewb-r1, MAIN_ROOM, 3, STAND)  # Irene Rábago, dom 15:11
ManuallyAssign([2019TORR29], _skewb-r1, MAIN_ROOM, 3, UNOFFICIAL)  # Marc Serra, dom 15:11

# 333-r1
ManuallyAssign([2022MENE02], _333-r1, MAIN_ROOM, 1, CAYRO)  # Irene Fraile, dom 15:30
ManuallyAssign([2022BAGU01], _333-r1, MAIN_ROOM, 1, STAND)  # Irene Rábago, dom 15:30
ManuallyAssign([2019TORR29], _333-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Marc Serra, dom 15:30
ManuallyAssign([2018FRAN17], _333-r1, MAIN_ROOM, 2, CAYRO)  # María Ángeles, dom 15:52
ManuallyAssign([2022BAGU01], _333-r1, MAIN_ROOM, 2, STAND)  # Irene Rábago, dom 15:52
ManuallyAssign([2023AZUR01, 2019TORR29], _333-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, dom 15:52
ManuallyAssign([2018FRAN17], _333-r1, MAIN_ROOM, 3, CAYRO)  # María Ángeles, dom 16:15
ManuallyAssign([2022MENE02], _333-r1, MAIN_ROOM, 3, STAND)  # Irene Fraile, dom 16:15
ManuallyAssign([2023AZUR01], _333-r1, MAIN_ROOM, 3, UNOFFICIAL)  # Jaione Bengoetxea, dom 16:15
ManuallyAssign([2018FRAN17], _333-r1, MAIN_ROOM, 4, CAYRO)  # María Ángeles, dom 16:37
ManuallyAssign([2022MENE02], _333-r1, MAIN_ROOM, 4, STAND)  # Irene Fraile, dom 16:37
ManuallyAssign([2023AZUR01, 2019TORR29], _333-r1, MAIN_ROOM, 4, UNOFFICIAL)  # Jaione Bengoetxea, Marc Serra, dom 16:37

# 333oh-r1
ManuallyAssign([2022BAGU01], _333oh-r1, MAIN_ROOM, 1, STAND)  # Irene Rábago, dom 17:40
ManuallyAssign([2019TORR29], _333oh-r1, MAIN_ROOM, 1, UNOFFICIAL)  # Marc Serra, dom 17:40
ManuallyAssign([2018FRAN17], _333oh-r1, MAIN_ROOM, 2, CAYRO)  # María Ángeles, dom 18:03
ManuallyAssign([2022MENE02], _333oh-r1, MAIN_ROOM, 2, STAND)  # Irene Fraile, dom 18:03
ManuallyAssign([2023AZUR01, 2018MOLI03], _333oh-r1, MAIN_ROOM, 2, UNOFFICIAL)  # Jaione Bengoetxea, Francisco Huertas, dom 18:03
ManuallyAssign([2022MENE02], _333oh-r1, MAIN_ROOM, 3, STAND)  # Irene Fraile, dom 18:26
ManuallyAssign([2018MOLI03], _333oh-r1, MAIN_ROOM, 3, UNOFFICIAL)  # Francisco Huertas, dom 18:26

