#include "_constants.cs"

# Args:
# 1: Person
Define("Unavailable",
       Concat(If(In(FM, ArrayProperty(SIDETASKS)),
                 [UnavailableBetween(2026-07-16T11:10, 2026-07-16T11:30),
                  UnavailableBetween(2026-07-17T10:45, 2026-07-17T11:05),
                  UnavailableBetween(2026-07-18T15:00, 2026-07-18T17:15)
                 ], []
                ),
              If((CompetingIn(_333mbf) && In(StringProperty(TYPE), CoreVolunteer())),
                 [UnavailableBetween(2026-07-16T13:40, 2026-07-16T14:10),
                  UnavailableBetween(2026-07-17T13:20, 2026-07-17T13:50)
                 ], []
                ),
              If(In(MBF11, ArrayProperty(SIDETASKS)),
                 [UnavailableBetween(2026-07-16T14:10, 2026-07-16T14:55)], []
                ),
              If(In(MBF12, ArrayProperty(SIDETASKS)),
                 [UnavailableBetween(2026-07-16T14:55, 2026-07-16T15:40)], []
                ),
              If(In(MBF21, ArrayProperty(SIDETASKS)),
                 [UnavailableBetween(2026-07-17T13:40, 2026-07-17T14:35)], []
                ),
              If(In(MBF22, ArrayProperty(SIDETASKS)),
                 [UnavailableBetween(2026-07-17T14:35, 2026-07-17T15:20)], []
                ),
              If(In(Name(), ["Amiel Engel", "Auke Boersma", "Mignon Engel"]),
                 [UnavailableBetween(2026-07-16T09:00, 2026-07-16T12:00)], []
                ),
              If((WcaId() == "2017POLY02"),
                 [UnavailableBetween(2026-07-16T11:00, 2026-07-16T12:00)], []
                ),
              If((WcaId() == "2016HOLZ01"),
                 [UnavailableBetween(2026-07-18T09:30, 2026-07-18T10:00)], []
                ),
              If((WcaId() == "2014MILE01"),
                 [UnavailableBetween(2026-07-18T10:00, 2026-07-18T10:30)], []
                ),
              If((WcaId() == "2014IFRA01"),
                 [UnavailableBetween(2026-07-18T16:00, 2026-07-18T16:30)], []
                ),
              If((WcaId() == "2011TRON02"),
                 [UnavailableBetween(2026-07-17T11:40, 2026-07-17T12:00)  # 333bf-r1-g1
                 ], []
                ),
              If((Name() == "Andrea van Diermen"),
                 [UnavailableBetween(2026-07-17T10:10, 2026-07-17T10:30), # skewb-r1-g5
                  UnavailableBetween(2026-07-17T14:20, 2026-07-17T14:40), # 222-r1-g1
                  UnavailableBetween(2026-07-18T11:10, 2026-07-18T11:25), # pyram-r1-g2
                  UnavailableBetween(2026-07-18T16:55, 2026-07-18T17:20)  # 333-r1-g7
                 ], []
                ),
              If((WcaId() == "2022RUSH01"),
                 [UnavailableBetween(2026-07-16T14:05, 2026-07-16T14:30), # 444-r1-g2
                  UnavailableBetween(2026-07-16T16:10, 2026-07-16T16:30), # clock-r1-g1
                  UnavailableBetween(2026-07-17T10:45, 2026-07-17T11:15), # 666-r1-g1
                  UnavailableBetween(2026-07-17T14:55, 2026-07-17T15:15), # 222-r1-g3
                  UnavailableBetween(2026-07-18T11:10, 2026-07-18T11:25), # pyram-r1-g2
                  UnavailableBetween(2026-07-18T16:10, 2026-07-18T16:55)  # 333-r1-g5-6
                 ], []
                ),
              If(In(Name(), ["Auke Boersma", "Martiniek Boersma"]),
                 [UnavailableBetween(2026-07-16T16:55, 2026-07-16T17:15), # clock-r1-g3
                  UnavailableBetween(2026-07-17T09:00, 2026-07-17T09:20), # skewb-r1-g1
                  UnavailableBetween(2026-07-17T16:10, 2026-07-17T16:30), # 222-r1-g7
                  UnavailableBetween(2026-07-18T12:10, 2026-07-18T12:35), # pyram-r1-g6
                  UnavailableBetween(2026-07-18T15:50, 2026-07-18T16:10)  # 333-r1-g4
                 ], []
                ),
              If((WcaId() == "2019BURG06"),
                 [UnavailableBetween(2026-07-18T12:10, 2026-07-18T12:35)  # pyram-r1-g6
                 ], []
                ),
              If((WcaId() == "2022JEHA01"),
                 [UnavailableBetween(2026-07-16T10:55, 2026-07-16T11:15), # 333oh-r1-g6
                  UnavailableBetween(2026-07-16T15:45, 2026-07-16T16:10), # 444-r1-g6
                  UnavailableBetween(2026-07-16T16:30, 2026-07-16T16:55), # clock-r1-g2
                  UnavailableBetween(2026-07-17T09:35, 2026-07-17T09:55), # skewb-r1-g3
                  UnavailableBetween(2026-07-17T16:10, 2026-07-17T16:30), # 222-r1-g7
                  UnavailableBetween(2026-07-18T11:45, 2026-07-18T12:00), # pyram-r1-g4
                  UnavailableBetween(2026-07-18T14:40, 2026-07-18T15:05)  # 333-r1-g1
                 ], []
                ),
              If((Name() == "Shanice Tam"),
                 [UnavailableBetween(2026-07-17T12:00, 2026-07-17T12:20), # 333bf-r1-g2
                  UnavailableBetween(2026-07-18T09:10, 2026-07-18T09:55), # 444bf-r1-g1
                  UnavailableBetween(2026-07-18T11:35, 2026-07-18T12:30)  # 555bf-r1-g1
                 ], []
                ),
              If((Name() == "Martine Boddin"),
                 [UnavailableBetween(2026-07-16T13:40, 2026-07-16T14:05), # 444-r1-g1
                  UnavailableBetween(2026-07-17T09:20, 2026-07-17T09:35), # skewb-r1-g2
                  UnavailableBetween(2026-07-17T14:55, 2026-07-17T15:15), # 222-r1-g3
                  UnavailableBetween(2026-07-18T16:35, 2026-07-18T16:55)  # 333-r1-g6
                 ], []
                ),
              If((WcaId() == "2014BEGU01"),
                 [UnavailableBetween(2026-07-19T10:45, 2026-07-19T11:30)  # 333-r2-g3-4
                 ], []
                )
             )
      )