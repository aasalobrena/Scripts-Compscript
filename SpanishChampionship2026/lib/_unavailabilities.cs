#include "_constants.cs"
#include "_helpers.cs"

# Returns StaffUnavailability
# Args:
# 1: Person
Define("Unavailable",
       Concat(Switch({1, Person},
                     [Tuple(2017MILL04, [UnavailableBetween(2026-12-06T16:00, 2026-12-06T20:00),
                                         UnavailableForDate(2026-12-07)
                                        ]
                           )
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
                 [UnavailableBetween(2026-12-05T10:55, 2025-12-05T11:40)],
                 []
                )
             )
      )
