#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"

Cluster(TEAM,
        5,
        Persons((StringProperty(TYPE) == STAGE)),
        StringProperty(PRETEAM),
        [BalanceConstraint(SIDE,
                           (StringProperty(TYPE) == SIDE),
                           4
                          ),
         LimitConstraint("555",  CanScramble(_555),   8, 5),
         LimitConstraint("666",  CanScramble(_666),  12, 5),
         LimitConstraint("777",  CanScramble(_777),   8, 5),
         LimitConstraint("minx", CanScramble(_minx),  8, 5),
         LimitConstraint("sq1",  CanScramble(_sq1),  10, 5),
         LimitConstraint("333 semi",   (CanScramble(_333) && (PsychSheetPosition(_333) > 150)),     10, 5),
         LimitConstraint("222 semi",   (CanScramble(_222) && (PsychSheetPosition(_222) > 150)),     10, 5),
         LimitConstraint("444 semi",   (CanScramble(_444) && (PsychSheetPosition(_444) > 150)),     10, 5),
         LimitConstraint("555 semi",   (CanScramble(_555) && (PsychSheetPosition(_555) > 150)),      7, 5),
         LimitConstraint("clock semi", (CanScramble(_clock) && (PsychSheetPosition(_clock) > 150)), 10, 5),
         LimitConstraint("pyram semi", (CanScramble(_pyram) && (PsychSheetPosition(_pyram) > 150)), 10, 5),
         LimitConstraint("sq1 semi",   (CanScramble(_sq1) && (PsychSheetPosition(_sq1) > 175)),      6, 5)
        ]
       )