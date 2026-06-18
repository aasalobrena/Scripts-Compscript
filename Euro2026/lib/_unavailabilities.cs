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
                )
             )
      )