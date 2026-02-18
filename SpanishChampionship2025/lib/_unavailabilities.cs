#include "_constants.cs"

# Args:
# 1: Person
Define("Unavailable",
       Concat(
        Switch({1, Person},
               [
                Tuple(2022HERN16, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Alejandro Jiménez Hernández
                Tuple(2025MORA11, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Alex Mora
                Tuple(2025BAGU03, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Cecilia Rábago Bagüés
                Tuple(2023FRAI01, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Daniel Olmedo Fraile
                Tuple(2022CHAM12, [UnavailableBetween(2025-12-06T09:00, 2025-12-06T10:00)]),   # Elena Filiberto Chamorro
                Tuple(2022MIED01, [UnavailableBetween(2025-12-06T09:00, 2025-12-06T09:15)]),   # Héctor Sanchis Miedes
                Tuple(2017OYAR02, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Ibai Nabarro Oyarzabal
                Tuple(2022HUIC01, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Imanol Azurmendi Huici
                Tuple(2023ABIN01, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Javier Suescun Abinzano
                Tuple(2015SANC18, [UnavailableBetween(2025-12-06T09:00, 2025-12-06T09:30)]),   # Josete Sánchez
                Tuple(2023MARS33, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Marcos Caballero Marsilla
                Tuple(2025PRIE04, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)]),   # Marcos Mora Prieto
                Tuple(2015SANC18, [UnavailableForDate(2025-12-06)]),                           # Omar Karim Melgar
                Tuple(2016PYWI01, [UnavailableBetween(2025-12-08T14:25, 2025-12-08T17:15)])    # Wilfrid Py
               ],
               defaultValue=[]),
        If((StringProperty(TEAM) == AUX_TEAM),
           [UnavailableBetween(2025-12-06T12:20, 2025-12-06T13:10),
            UnavailableBetween(2025-12-07T09:00, 2025-12-07T09:20)], []),
        If(CompetingIn(_333mbf),
           [UnavailableBetween(2025-12-06T12:20, 2025-12-06T12:50)], []),
        If(Or(CompetingIn(_777),
              CompetingIn(_clock),
              CompetingIn(_666),
              CompetingIn(_333oh),
              CompetingIn(_sq1),
              CompetingIn(_minx),
              CompetingIn(_555),
              CompetingIn(_333bf),
              (WcaId() == "2025PERE37")),
           [], [UnavailableForDate(2025-12-06)])
       ))