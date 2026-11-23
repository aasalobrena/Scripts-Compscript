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
                      # Invitados del streaming: no tienen staff mientras castean (ver 0_precomp/6a_casters.cs)
                      Tuple(2018ARGA01, [UnavailableBetween(2026-12-06T11:50, 2026-12-06T12:08),  # 222-r1
                                         UnavailableBetween(2026-12-06T12:28, 2026-12-06T12:46),  # 222-r1
                                         UnavailableBetween(2026-12-07T11:05, 2026-12-07T11:45),  # 222-r2 (provisional)
                                         UnavailableBetween(2026-12-07T16:15, 2026-12-07T16:35)  # 222-r3 (provisional)
                                        ]
                           ),  # Ibai Tobar (invitado del streaming)
                      Tuple(2022RUIZ02, [UnavailableBetween(2026-12-06T15:53, 2026-12-06T17:00),  # 333-r1
                                         UnavailableBetween(2026-12-07T09:05, 2026-12-07T10:15),  # 333-r2 (provisional)
                                         UnavailableBetween(2026-12-07T12:55, 2026-12-07T13:15)  # 333-r3 (provisional)
                                        ]
                           ),  # Marisa Revaliente (invitado del streaming)
                      Tuple(2015GONZ08, [UnavailableBetween(2026-12-06T10:35, 2026-12-06T11:50),  # 444-r1
                                         UnavailableBetween(2026-12-07T10:15, 2026-12-07T11:05),  # 444-r2 (provisional)
                                         UnavailableBetween(2026-12-07T15:50, 2026-12-07T16:15)  # 444-r3 (provisional)
                                        ]
                           ),  # Biel Salmons (invitado del streaming)
                      Tuple(2014LOPE04, [UnavailableBetween(2026-12-05T12:08, 2026-12-05T12:35),  # 666-r1
                                         UnavailableBetween(2026-12-05T17:15, 2026-12-05T17:40),  # 777-r2 (provisional)
                                         UnavailableBetween(2026-12-06T19:35, 2026-12-06T20:00)  # 666-r2 (provisional)
                                        ]
                           ),  # Antonio López (invitado del streaming)
                      Tuple(2016RUIZ05, [UnavailableBetween(2026-12-05T12:55, 2026-12-05T13:15),  # 333bf-r1
                                         UnavailableBetween(2026-12-05T16:55, 2026-12-05T17:15),  # 333bf-r2 (provisional)
                                         UnavailableBetween(2026-12-06T19:15, 2026-12-06T19:35)  # 333bf-r3 (provisional)
                                        ]
                           ),  # Iker Carrasco (invitado del streaming)
                      Tuple(2024ZARR01, [UnavailableBetween(2026-12-06T18:04, 2026-12-06T18:50),  # 333oh-r1
                                         UnavailableBetween(2026-12-07T11:45, 2026-12-07T12:20),  # 333oh-r2 (provisional)
                                         UnavailableBetween(2026-12-07T15:05, 2026-12-07T15:30)  # 333oh-r3 (provisional)
                                        ]
                           ),  # Mikel Manterola (invitado del streaming)
                      Tuple(2023FERN54, [UnavailableBetween(2026-12-05T09:30, 2026-12-05T10:00),  # clock-r1
                                         UnavailableBetween(2026-12-05T17:40, 2026-12-05T18:05)  # clock-r2 (provisional)
                                        ]
                           ),  # Sergio Márquez (invitado del streaming)
                      Tuple(2023VELA19, [UnavailableBetween(2026-12-05T16:25, 2026-12-05T16:55),  # minx-r1
                                         UnavailableBetween(2026-12-06T18:50, 2026-12-06T19:15)  # minx-r2 (provisional)
                                        ]
                           ),  # Pablo Amoraga (invitado del streaming)
                      Tuple(2022LARR02, [UnavailableBetween(2026-12-06T09:34, 2026-12-06T10:10),  # pyram-r1
                                         UnavailableBetween(2026-12-06T17:00, 2026-12-06T17:40),  # pyram-r2 (provisional)
                                         UnavailableBetween(2026-12-07T15:30, 2026-12-07T15:50)  # pyram-r3 (provisional)
                                        ]
                           ),  # Aratz Larruzea (invitado del streaming)
                      Tuple(2023LANG03, [UnavailableBetween(2026-12-06T14:54, 2026-12-06T15:30),  # skewb-r1
                                         UnavailableBetween(2026-12-07T12:20, 2026-12-07T12:55),  # skewb-r2 (provisional)
                                         UnavailableBetween(2026-12-07T14:45, 2026-12-07T15:05)  # skewb-r3 (provisional)
                                        ]
                           ),  # Alex Rosado (invitado del streaming)
                      Tuple(2010GARC02, [UnavailableBetween(2026-12-05T11:18, 2026-12-05T11:40),  # sq1-r1
                                         UnavailableBetween(2026-12-05T18:30, 2026-12-05T18:55)  # sq1-r2 (provisional)
                                        ]
                           )   # Carlos Méndez (invitado del streaming)
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
