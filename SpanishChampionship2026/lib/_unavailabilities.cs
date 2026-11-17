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
                      Tuple(2024VILL45, [UnavailableForDate(2026-12-05)])                          # Ashtonn Villain
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
