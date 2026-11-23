#include "../lib/_constants.cs"

# Casteo del streaming (casters e invitados), según Casters.xlsx.
# Ejecutar UNA sola vez, después de 6_assign_main y antes de 7_assign_main_volunteers (y del staff de 4_assign_side),
# sobre el WCIF con los grupos de competidor ya generados. 6a (casters) va antes que 6b (stand AES).
# Las tareas de staff de los invitados las evitan las indisponibilidades de lib/_unavailabilities.cs.

# 1. Cambios de grupo para que siempre haya 2 casters libres. Van PRIMERO: ManuallyAssign de
#    competidor borra todas las asignaciones de esa persona en los grupos de esa ronda.
ManuallyAssign([2012GONZ10], _777-r1, BIZKAIA_STAGE, 2)  # Eder: Bizkaia g1 -> g2
ManuallyAssign([2012GONZ10], _444-r1, BIZKAIA_STAGE, 1)  # Eder: Bizkaia g4 -> g1
ManuallyAssign([2020NUNE01], _333-r1, BIZKAIA_STAGE, 1)  # Arián: Bizkaia g2 -> g1

# 2. Primeras rondas
# clock-r1
ManuallyAssign([2009ORTI01, 2020NUNE01], _clock-r1, MAIN_ROOM, 1, CASTER)  # Dani y Arián, sáb 09:00
ManuallyAssign([2020NUNE01, 2012GONZ10], _clock-r1, MAIN_ROOM, 2, CASTER)  # Arián y Eder, sáb 09:30
ManuallyAssign([2023FERN54], _clock-r1, MAIN_ROOM, 2, CASTER)  # invitado: Sergio Márquez

# 777-r1
ManuallyAssign([2012GONZ10, 2009ORTI01], _777-r1, MAIN_ROOM, 1, CASTER)  # Eder y Dani, sáb 10:00
ManuallyAssign([2022MENG02, 2020NUNE01], _777-r1, MAIN_ROOM, 2, CASTER)  # Oscar y Arián, sáb 10:27

# sq1-r1
ManuallyAssign([2020NUNE01, 2012GONZ10], _sq1-r1, MAIN_ROOM, 1, CASTER)  # Arián y Eder, sáb 10:55
ManuallyAssign([2009ORTI01, 2020NUNE01], _sq1-r1, MAIN_ROOM, 2, CASTER)  # Dani y Arián, sáb 11:17
ManuallyAssign([2010GARC02], _sq1-r1, MAIN_ROOM, 2, CASTER)  # invitado: Carlos Méndez

# 666-r1
ManuallyAssign([2020NUNE01, 2009ORTI01], _666-r1, MAIN_ROOM, 1, CASTER)  # Arián y Dani, sáb 11:40
ManuallyAssign([2012GONZ10, 2022MENG02], _666-r1, MAIN_ROOM, 2, CASTER)  # Eder y Oscar, sáb 12:07
ManuallyAssign([2014LOPE04], _666-r1, MAIN_ROOM, 2, CASTER)  # invitado: Antonio López

# 333bf-r1
ManuallyAssign([2012GONZ10, 2022MENG02], _333bf-r1, MAIN_ROOM, 1, CASTER)  # Eder y Oscar, sáb 12:35
ManuallyAssign([2009ORTI01, 2020NUNE01], _333bf-r1, MAIN_ROOM, 2, CASTER)  # Dani y Arián, sáb 12:55
ManuallyAssign([2016RUIZ05], _333bf-r1, MAIN_ROOM, 2, CASTER)  # invitado: Iker Carrasco

# 555-r1
ManuallyAssign([2022MENG02, 2009ORTI01], _555-r1, MAIN_ROOM, 1, CASTER)  # Oscar y Dani, sáb 14:50
ManuallyAssign([2012GONZ10, 2020NUNE01], _555-r1, MAIN_ROOM, 2, CASTER)  # Eder y Arián, sáb 15:15

# minx-r1
ManuallyAssign([2020NUNE01, 2012GONZ10], _minx-r1, MAIN_ROOM, 1, CASTER)  # Arián y Eder, sáb 15:55
ManuallyAssign([2012GONZ10, 2009ORTI01], _minx-r1, MAIN_ROOM, 2, CASTER)  # Eder y Dani, sáb 16:25
ManuallyAssign([2023VELA19], _minx-r1, MAIN_ROOM, 2, CASTER)  # invitado: Pablo Amoraga

# pyram-r1
ManuallyAssign([2009ORTI01, 2020NUNE01], _pyram-r1, MAIN_ROOM, 1, CASTER)  # Dani y Arián, dom 09:15
ManuallyAssign([2009ORTI01, 2020NUNE01], _pyram-r1, MAIN_ROOM, 2, CASTER)  # Dani y Arián, dom 09:33
ManuallyAssign([2022LARR02], _pyram-r1, MAIN_ROOM, 2, CASTER)  # invitado: Aratz Larruzea
ManuallyAssign([2009ORTI01, 2012GONZ10], _pyram-r1, MAIN_ROOM, 3, CASTER)  # Dani y Eder, dom 09:51
ManuallyAssign([2022LARR02], _pyram-r1, MAIN_ROOM, 3, CASTER)  # invitado: Aratz Larruzea

# 444-r1
ManuallyAssign([2022MENG02, 2020NUNE01], _444-r1, MAIN_ROOM, 1, CASTER)  # Oscar y Arián, dom 10:10
ManuallyAssign([2012GONZ10, 2022MENG02], _444-r1, MAIN_ROOM, 2, CASTER)  # Eder y Oscar, dom 10:35
ManuallyAssign([2015GONZ08], _444-r1, MAIN_ROOM, 2, CASTER)  # invitado: Biel Salmons
ManuallyAssign([2012GONZ10, 2022MENG02], _444-r1, MAIN_ROOM, 3, CASTER)  # Eder y Oscar, dom 11:00
ManuallyAssign([2015GONZ08], _444-r1, MAIN_ROOM, 3, CASTER)  # invitado: Biel Salmons
ManuallyAssign([2012GONZ10, 2009ORTI01], _444-r1, MAIN_ROOM, 4, CASTER)  # Eder y Dani, dom 11:25
ManuallyAssign([2015GONZ08], _444-r1, MAIN_ROOM, 4, CASTER)  # invitado: Biel Salmons

# 222-r1
ManuallyAssign([2020NUNE01, 2012GONZ10], _222-r1, MAIN_ROOM, 1, CASTER)  # Arián y Eder, dom 11:50
ManuallyAssign([2018ARGA01], _222-r1, MAIN_ROOM, 1, CASTER)  # invitado: Ibai Tobar
ManuallyAssign([2009ORTI01, 2020NUNE01], _222-r1, MAIN_ROOM, 2, CASTER)  # Dani y Arián, dom 12:08
ManuallyAssign([2009ORTI01, 2020NUNE01], _222-r1, MAIN_ROOM, 3, CASTER)  # Dani y Arián, dom 12:27
ManuallyAssign([2018ARGA01], _222-r1, MAIN_ROOM, 3, CASTER)  # invitado: Ibai Tobar
ManuallyAssign([2009ORTI01, 2012GONZ10], _222-r1, MAIN_ROOM, 4, CASTER)  # Dani y Eder, dom 12:46

# skewb-r1
ManuallyAssign([2009ORTI01, 2012GONZ10], _skewb-r1, MAIN_ROOM, 1, CASTER)  # Dani y Eder, dom 14:35
ManuallyAssign([2009ORTI01, 2012GONZ10], _skewb-r1, MAIN_ROOM, 2, CASTER)  # Dani y Eder, dom 14:53
ManuallyAssign([2023LANG03], _skewb-r1, MAIN_ROOM, 2, CASTER)  # invitado: Alex Rosado
ManuallyAssign([2009ORTI01, 2012GONZ10], _skewb-r1, MAIN_ROOM, 3, CASTER)  # Dani y Eder, dom 15:11
ManuallyAssign([2023LANG03], _skewb-r1, MAIN_ROOM, 3, CASTER)  # invitado: Alex Rosado

# 333-r1
ManuallyAssign([2012GONZ10, 2009ORTI01], _333-r1, MAIN_ROOM, 1, CASTER)  # Eder y Dani, dom 15:30
ManuallyAssign([2012GONZ10, 2020NUNE01], _333-r1, MAIN_ROOM, 2, CASTER)  # Eder y Arián, dom 15:52
ManuallyAssign([2022RUIZ02], _333-r1, MAIN_ROOM, 2, CASTER)  # invitado: Marisa Revaliente
ManuallyAssign([2012GONZ10, 2020NUNE01], _333-r1, MAIN_ROOM, 3, CASTER)  # Eder y Arián, dom 16:15
ManuallyAssign([2022RUIZ02], _333-r1, MAIN_ROOM, 3, CASTER)  # invitado: Marisa Revaliente
ManuallyAssign([2020NUNE01, 2009ORTI01], _333-r1, MAIN_ROOM, 4, CASTER)  # Arián y Dani, dom 16:37
ManuallyAssign([2022RUIZ02], _333-r1, MAIN_ROOM, 4, CASTER)  # invitado: Marisa Revaliente

# 333oh-r1
ManuallyAssign([2009ORTI01, 2012GONZ10], _333oh-r1, MAIN_ROOM, 1, CASTER)  # Dani y Eder, dom 17:40
ManuallyAssign([2009ORTI01, 2020NUNE01], _333oh-r1, MAIN_ROOM, 2, CASTER)  # Dani y Arián, dom 18:03
ManuallyAssign([2024ZARR01], _333oh-r1, MAIN_ROOM, 2, CASTER)  # invitado: Mikel Manterola
ManuallyAssign([2020NUNE01, 2012GONZ10], _333oh-r1, MAIN_ROOM, 3, CASTER)  # Arián y Eder, dom 18:26
ManuallyAssign([2024ZARR01], _333oh-r1, MAIN_ROOM, 3, CASTER)  # invitado: Mikel Manterola

# 3. Rondas siguientes: PROVISIONAL. Descomentar cuando se publiquen los grupos y comprobar que
#    nadie de aquí compite a esa hora (si se clasifica, entra el siguiente caster libre).
# 333bf-r2
# ManuallyAssign([2009ORTI01, 2020NUNE01], _333bf-r2, MAIN_ROOM, 1, CASTER)  # Dani y Arián, sáb 16:55
# ManuallyAssign([2016RUIZ05], _333bf-r2, MAIN_ROOM, 1, CASTER)  # invitado: Iker Carrasco

# 777-r2
# ManuallyAssign([2012GONZ10, 2022MENG02], _777-r2, MAIN_ROOM, 1, CASTER)  # Eder y Oscar, sáb 17:15
# ManuallyAssign([2014LOPE04], _777-r2, MAIN_ROOM, 1, CASTER)  # invitado: Antonio López

# clock-r2
# ManuallyAssign([2009ORTI01, 2020NUNE01], _clock-r2, MAIN_ROOM, 1, CASTER)  # Dani y Arián, sáb 17:40
# ManuallyAssign([2023FERN54], _clock-r2, MAIN_ROOM, 1, CASTER)  # invitado: Sergio Márquez

# 555-r2
# ManuallyAssign([2012GONZ10, 2022MENG02], _555-r2, MAIN_ROOM, 1, CASTER)  # Eder y Oscar, sáb 18:05

# sq1-r2
# ManuallyAssign([2009ORTI01, 2020NUNE01], _sq1-r2, MAIN_ROOM, 1, CASTER)  # Dani y Arián, sáb 18:30
# ManuallyAssign([2010GARC02], _sq1-r2, MAIN_ROOM, 1, CASTER)  # invitado: Carlos Méndez

# pyram-r2
# ManuallyAssign([2009ORTI01, 2020NUNE01], _pyram-r2, MAIN_ROOM, 1, CASTER)  # Dani y Arián, dom 17:00
# ManuallyAssign([2022LARR02], _pyram-r2, MAIN_ROOM, 1, CASTER)  # invitado: Aratz Larruzea
# ManuallyAssign([2009ORTI01, 2020NUNE01], _pyram-r2, MAIN_ROOM, 2, CASTER)  # Dani y Arián, dom 17:20
# ManuallyAssign([2022LARR02], _pyram-r2, MAIN_ROOM, 2, CASTER)  # invitado: Aratz Larruzea

# minx-r2
# ManuallyAssign([2020NUNE01, 2012GONZ10], _minx-r2, MAIN_ROOM, 1, CASTER)  # Arián y Eder, dom 18:50
# ManuallyAssign([2023VELA19], _minx-r2, MAIN_ROOM, 1, CASTER)  # invitado: Pablo Amoraga

# 333bf-r3
# ManuallyAssign([2009ORTI01, 2020NUNE01], _333bf-r3, MAIN_ROOM, 1, CASTER)  # Dani y Arián, dom 19:15
# ManuallyAssign([2016RUIZ05], _333bf-r3, MAIN_ROOM, 1, CASTER)  # invitado: Iker Carrasco

# 666-r2
# ManuallyAssign([2012GONZ10, 2022MENG02], _666-r2, MAIN_ROOM, 1, CASTER)  # Eder y Oscar, dom 19:35
# ManuallyAssign([2014LOPE04], _666-r2, MAIN_ROOM, 1, CASTER)  # invitado: Antonio López

# 333-r2
# ManuallyAssign([2012GONZ10, 2020NUNE01], _333-r2, MAIN_ROOM, 1, CASTER)  # Eder y Arián, lun 09:05
# ManuallyAssign([2022RUIZ02], _333-r2, MAIN_ROOM, 1, CASTER)  # invitado: Marisa Revaliente
# ManuallyAssign([2012GONZ10, 2020NUNE01], _333-r2, MAIN_ROOM, 2, CASTER)  # Eder y Arián, lun 09:28
# ManuallyAssign([2022RUIZ02], _333-r2, MAIN_ROOM, 2, CASTER)  # invitado: Marisa Revaliente
# ManuallyAssign([2012GONZ10, 2020NUNE01], _333-r2, MAIN_ROOM, 3, CASTER)  # Eder y Arián, lun 09:51
# ManuallyAssign([2022RUIZ02], _333-r2, MAIN_ROOM, 3, CASTER)  # invitado: Marisa Revaliente

# 444-r2
# ManuallyAssign([2012GONZ10, 2022MENG02], _444-r2, MAIN_ROOM, 1, CASTER)  # Eder y Oscar, lun 10:15
# ManuallyAssign([2015GONZ08], _444-r2, MAIN_ROOM, 1, CASTER)  # invitado: Biel Salmons
# ManuallyAssign([2012GONZ10, 2022MENG02], _444-r2, MAIN_ROOM, 2, CASTER)  # Eder y Oscar, lun 10:40
# ManuallyAssign([2015GONZ08], _444-r2, MAIN_ROOM, 2, CASTER)  # invitado: Biel Salmons

# 222-r2
# ManuallyAssign([2009ORTI01, 2020NUNE01], _222-r2, MAIN_ROOM, 1, CASTER)  # Dani y Arián, lun 11:05
# ManuallyAssign([2018ARGA01], _222-r2, MAIN_ROOM, 1, CASTER)  # invitado: Ibai Tobar
# ManuallyAssign([2009ORTI01, 2020NUNE01], _222-r2, MAIN_ROOM, 2, CASTER)  # Dani y Arián, lun 11:25
# ManuallyAssign([2018ARGA01], _222-r2, MAIN_ROOM, 2, CASTER)  # invitado: Ibai Tobar

# 333oh-r2
# ManuallyAssign([2009ORTI01, 2020NUNE01], _333oh-r2, MAIN_ROOM, 1, CASTER)  # Dani y Arián, lun 11:45
# ManuallyAssign([2024ZARR01], _333oh-r2, MAIN_ROOM, 1, CASTER)  # invitado: Mikel Manterola

# skewb-r2
# ManuallyAssign([2009ORTI01, 2012GONZ10], _skewb-r2, MAIN_ROOM, 1, CASTER)  # Dani y Eder, lun 12:20
# ManuallyAssign([2023LANG03], _skewb-r2, MAIN_ROOM, 1, CASTER)  # invitado: Alex Rosado
# ManuallyAssign([2009ORTI01, 2012GONZ10], _skewb-r2, MAIN_ROOM, 2, CASTER)  # Dani y Eder, lun 12:37
# ManuallyAssign([2023LANG03], _skewb-r2, MAIN_ROOM, 2, CASTER)  # invitado: Alex Rosado

# 333-r3
# ManuallyAssign([2012GONZ10, 2020NUNE01], _333-r3, MAIN_ROOM, 1, CASTER)  # Eder y Arián, lun 12:55
# ManuallyAssign([2022RUIZ02], _333-r3, MAIN_ROOM, 1, CASTER)  # invitado: Marisa Revaliente

# skewb-r3
# ManuallyAssign([2009ORTI01, 2012GONZ10], _skewb-r3, MAIN_ROOM, 1, CASTER)  # Dani y Eder, lun 14:45
# ManuallyAssign([2023LANG03], _skewb-r3, MAIN_ROOM, 1, CASTER)  # invitado: Alex Rosado

# 333oh-r3
# ManuallyAssign([2009ORTI01, 2020NUNE01], _333oh-r3, MAIN_ROOM, 1, CASTER)  # Dani y Arián, lun 15:05
# ManuallyAssign([2024ZARR01], _333oh-r3, MAIN_ROOM, 1, CASTER)  # invitado: Mikel Manterola

# pyram-r3
# ManuallyAssign([2009ORTI01, 2020NUNE01], _pyram-r3, MAIN_ROOM, 1, CASTER)  # Dani y Arián, lun 15:30
# ManuallyAssign([2022LARR02], _pyram-r3, MAIN_ROOM, 1, CASTER)  # invitado: Aratz Larruzea

# 444-r3
# ManuallyAssign([2012GONZ10, 2022MENG02], _444-r3, MAIN_ROOM, 1, CASTER)  # Eder y Oscar, lun 15:50
# ManuallyAssign([2015GONZ08], _444-r3, MAIN_ROOM, 1, CASTER)  # invitado: Biel Salmons

# 222-r3
# ManuallyAssign([2009ORTI01, 2020NUNE01], _222-r3, MAIN_ROOM, 1, CASTER)  # Dani y Arián, lun 16:15
# ManuallyAssign([2018ARGA01], _222-r3, MAIN_ROOM, 1, CASTER)  # invitado: Ibai Tobar

