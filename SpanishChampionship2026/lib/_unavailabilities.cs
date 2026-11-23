#include "_constants.cs"
#include "_helpers.cs"

# Returns StaffUnavailability
# Args:
# 1: Person
Define("Unavailable",
       Concat(Switch({1, Person},
                     [Tuple(2017MILL04, [UnavailableBetween(2026-12-06T16:00, 2026-12-06T20:00),   # Zachary Miller
                                         UnavailableForDate(2026-12-07)
                                        ]
                           ),
                      Tuple(2017GONZ24, [UnavailableForDate(2026-12-06),                           # Asier González Santocildes
                                         UnavailableForDate(2026-12-07)
                                        ]
                           ),
                      Tuple(2022RODR52, [UnavailableBetween(2026-12-05T09:30, 2026-12-05T12:55)]), # Gabriel Rasines Rodríguez
                      Tuple(2014USER01, [UnavailableForDate(2026-12-05),                           # Rocío Fernández Usero
                                         UnavailableForDate(2026-12-07)
                                        ]
                           ),
                      Tuple(2019GEAA01, [UnavailableForDate(2026-12-05)]),                         # Albert Garriga Gea
                      Tuple(2024VILL45, [UnavailableForDate(2026-12-05)]),                         # Ashtonn Villain
                      Tuple(2023MONT04, [UnavailableBetween(2026-12-05T09:00, 2026-12-05T10:00)]), # Miguel Martínez Montañes
                      Tuple(2018ARGA01, [UnavailableBetween(2026-12-06T11:50, 2026-12-06T12:08),   # Ibai Tobar Argaiz
                                         UnavailableBetween(2026-12-06T12:28, 2026-12-06T12:46)
                                        ]
                           ),
                      Tuple(2022RUIZ02, [UnavailableBetween(2026-12-06T15:53, 2026-12-06T17:00)]), # Marisa Revaliente Ruiz
                      Tuple(2015GONZ08, [UnavailableBetween(2026-12-06T10:35, 2026-12-06T11:50)]), # Biel Salmons Gonzalez
                      Tuple(2014LOPE04, [UnavailableBetween(2026-12-05T12:08, 2026-12-05T12:35)]), # Antonio López
                      Tuple(2016RUIZ05, [UnavailableBetween(2026-12-05T12:55, 2026-12-05T13:15)]), # Iker Carrasco Ruiz
                      Tuple(2024ZARR01, [UnavailableBetween(2026-12-06T18:04, 2026-12-06T18:50)]), # Mikel Manterola Zarraga
                      Tuple(2023FERN54, [UnavailableBetween(2026-12-05T09:30, 2026-12-05T10:00)]), # Sergio Márquez Fernández-Jardón
                      Tuple(2023VELA19, [UnavailableBetween(2026-12-05T16:25, 2026-12-05T16:55)]), # Pablo Amoraga Velasco
                      Tuple(2022LARR02, [UnavailableBetween(2026-12-06T09:34, 2026-12-06T10:10)]), # Aratz Larruzea
                      Tuple(2023LANG03, [UnavailableBetween(2026-12-06T14:54, 2026-12-06T15:30)]), # Alex Rosado Saez de Langarica
                      Tuple(2010GARC02, [UnavailableBetween(2026-12-05T11:18, 2026-12-05T11:40)])  # Carlos Méndez García-Barroso
                     ],
                     defaultValue=[]
                    ),
              If((InTeam([SIDE_TEAM]) || InDelegateCluster([1])),
                 [UnavailableBetween(2026-12-05T11:40, 2026-12-05T12:35),
                  UnavailableBetween(2026-12-06T09:15, 2026-12-06T09:50)
                 ],
                 []
                ),
              If(CompetingIn(_333mbf),
                 [UnavailableBetween(2026-12-05T10:55, 2026-12-05T11:40)],
                 []
                ),
              If(CompetingInPuzzles(INDIVIDUAL),
                 [UnavailableBetween(2026-12-05T11:00, 2026-12-05T13:30)],
                 []
                ),
              If(CompetingInPuzzles(PAREJAS),
                 [UnavailableBetween(2026-12-05T16:30, 2026-12-05T18:30)],
                 []
                )
             )
      )
