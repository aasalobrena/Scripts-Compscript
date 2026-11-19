#include "../lib/_constants.cs"
#include "../lib/_assign.cs"
#include "../lib/_volunteers.cs"

# DEV
# AddResults(_444-r2, Persons((PsychSheetPosition(_444) <= 150)))
# AddResults(_222-r2, Persons((PsychSheetPosition(_222) <= 150)))
# AddResults(_skewb-r2, Persons((PsychSheetPosition(_skewb) <= 150)))
# AddResults(_333-r2, Persons((PsychSheetPosition(_333) <= 225)))
# AddResults(_pyram-r3, Persons((PsychSheetPosition(_pyram) <= 20)))
# AddResults(_333oh-r2, Persons((PsychSheetPosition(_333oh) <= 75)))

FirstRoundAssignGroups(_333-r2, [], 4, 21, MakeArray<Round>(), [])
Map([_444-r2, _222-r2, _skewb-r2],
    SecondRoundAssignGroups(Arg<Round>())
   )
FinalAssignGroups(_pyram-r3)
AssignGroups(_333oh-r2,
             [AssignmentSet(BIZKAIA_STAGE,
                            (Seed(_333oh-r2) <= 21),
                            (Stage() == BIZKAIA_STAGE)
                           ),
              AssignmentSet(GIPUZKOA_STAGE,
                            (Seed(_333oh-r2) <= 48),
                            (Stage() == GIPUZKOA_STAGE)
                           ),
              AssignmentSet(ARABA_STAGE,
                            true,
                            (Stage() == ARABA_STAGE)
                           )
             ]
            )

Map([_333-r2, _444-r2, _222-r2, _333oh-r2, _skewb-r2],
    AllStagesAssignStaff(Arg<Round>())
   )
FinalAssignStaff(_pyram-r3, x)
