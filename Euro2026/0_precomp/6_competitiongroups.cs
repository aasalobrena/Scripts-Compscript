#include "../lib/_constants.cs"

ClearCompetitionGroupsAssignments(Persons(true))

# Side Room volunteers

CreateCompetitionGroupsAssignments(Persons(In(StringProperty(TYPE), SideVolunteer())),
                                   "Side Room Setup",
                                   2026-07-16T08:00,
                                   2026-07-16T09:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(FM, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Fewest Moves Grading",
                                   2026-07-16T11:10,
                                   2026-07-16T11:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(MBF11, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Multi-Blind Scrambling",
                                   2026-07-16T14:10,
                                   2026-07-16T14:55,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(MBF12, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Multi-Blind Scrambling",
                                   2026-07-16T14:55,
                                   2026-07-16T15:40,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons((StringProperty(TYPE) == SIDELEADER)),
                                   "Side Room Setup",
                                   2026-07-16T16:55,
                                   2026-07-16T17:05,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(FM, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Fewest Moves Grading",
                                   2026-07-17T10:45,
                                   2026-07-17T11:05,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(MBF21, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Multi-Blind Scrambling",
                                   2026-07-17T13:40,
                                   2026-07-17T14:35,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(MBF22, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Multi-Blind Scrambling",
                                   2026-07-17T14:40,
                                   2026-07-17T15:20,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(MBF, ArrayProperty(SIDETASKS))),
                                   "Side Room Setup",
                                   2026-07-17T16:35,
                                   2026-07-17T16:45,
                                   true
                                  )
CreateCompetitionGroupsAssignments(Persons(In(FM, ArrayProperty(SIDETASKS))),
                                   "3x3x3 Fewest Moves Grading & Tear Down",
                                   2026-07-18T16:15,
                                   2026-07-18T17:15,
                                   true
                                  )

# WCA Board meetings

CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2022HAYL02") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-16T09:30,
                                   2026-07-16T10:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2017POLY02") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-16T11:00,
                                   2026-07-16T12:00
                                  )
CreateCompetitionGroupsAssignments(Persons((In(WcaId(), ["2013WALL03", "2016ZENK01"]) || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-16T14:00,
                                   2026-07-16T14:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2014ZAKR01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-16T15:30,
                                   2026-07-16T16:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2012GOOD02") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-16T17:30,
                                   2026-07-16T18:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2016MORA24") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-17T09:30,
                                   2026-07-17T10:30
                                  )
CreateCompetitionGroupsAssignments(Persons((In(WcaId(), ["2016SINN01", "2016WHEA01"]) || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-17T11:20,
                                   2026-07-17T11:50
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2012CANT02") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-17T13:20,
                                   2026-07-17T13:50
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2012BILL01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-17T14:30,
                                   2026-07-17T15:30
                                  )
CreateCompetitionGroupsAssignments(Persons((In(WcaId(), ["2019PASQ01", "2017MATT06", "2017GUNT01", "2013PAPA01"]) || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-17T16:00,
                                   2026-07-17T16:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2015SALO01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-17T16:30,
                                   2026-07-17T17:00
                                  )
CreateCompetitionGroupsAssignments(Persons((In(WcaId(), ["2016HOLZ01", "2021MOSE02"]) || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-18T09:30,
                                   2026-07-18T10:00
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2014MILE01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-18T10:00,
                                   2026-07-18T10:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2018FOLD01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-18T11:30,
                                   2026-07-18T12:30
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2014IFRA01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-18T16:00,
                                   2026-07-18T16:30
                                  )
CreateCompetitionGroupsAssignments(Persons((In(WcaId(), ["2016BEAU03", "2015HENN02", "2017KELL08"]) || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-18T16:30,
                                   2026-07-18T17:00
                                  )
CreateCompetitionGroupsAssignments(Persons(((WcaId() == "2015JORG01") || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-18T17:00,
                                   2026-07-18T17:30
                                  )
CreateCompetitionGroupsAssignments(Persons((In(WcaId(), ["2014BEGU01", "2022TREM02"]) || (StringProperty(TYPE) == BOARD))),
                                   "WCA Board Meeting",
                                   2026-07-19T11:00,
                                   2026-07-19T11:30
                                  )

# Autographs Booth

CreateCompetitionGroupsAssignments([2022STOJ03, 2021KASP01],
                                   "Autographs at WCA Booth",
                                   2026-07-16T14:00,
                                   2026-07-16T14:30
                                  )
CreateCompetitionGroupsAssignments([2021PRAS02, 2014DETL01],
                                   "Autographs at WCA Booth",
                                   2026-07-16T14:30,
                                   2026-07-16T14:55
                                  )
CreateCompetitionGroupsAssignments([2022LARR02, 2012PATE01],
                                   "Autographs at WCA Booth",
                                   2026-07-16T15:00,
                                   2026-07-16T15:30
                                  )
CreateCompetitionGroupsAssignments([2018KUZM02, 2021ZAJD03],
                                   "Autographs at WCA Booth",
                                   2026-07-16T16:00,
                                   2026-07-16T16:30
                                  )
CreateCompetitionGroupsAssignments([2016KOLA02],
                                   "Autographs at WCA Booth",
                                   2026-07-17T11:50,
                                   2026-07-17T12:20
                                  )
CreateCompetitionGroupsAssignments([2012PONC02, 2020ARCH01],
                                   "Autographs at WCA Booth",
                                   2026-07-17T14:00,
                                   2026-07-17T14:30
                                  )
CreateCompetitionGroupsAssignments([2003VAND01, 2022SAMS03],
                                   "Autographs at WCA Booth",
                                   2026-07-17T14:30,
                                   2026-07-17T14:55
                                  )
CreateCompetitionGroupsAssignments([2018GRAI01, 2017GARR05],
                                   "Autographs at WCA Booth",
                                   2026-07-17T15:00,
                                   2026-07-17T15:30
                                  )
CreateCompetitionGroupsAssignments([2018DALO01, 2018HABE02],
                                   "Autographs at WCA Booth",
                                   2026-07-18T10:00,
                                   2026-07-18T10:30
                                  )
CreateCompetitionGroupsAssignments([2013BOBE01, 2020BARA02],
                                   "Autographs at WCA Booth",
                                   2026-07-18T10:30,
                                   2026-07-18T11:00
                                  )
CreateCompetitionGroupsAssignments([2012BEAH01, 2010WEYE02],
                                   "Autographs at WCA Booth",
                                   2026-07-18T11:00,
                                   2026-07-18T11:30
                                  )
CreateCompetitionGroupsAssignments([2017GUID01, 2017TRAN24],
                                   "Autographs at WCA Booth",
                                   2026-07-18T11:30,
                                   2026-07-18T12:00
                                  )

# WCA Booth volunteers

CreateCompetitionGroupsAssignments([2024CONE01],
                                   "Registration",
                                   2026-07-16T08:00,
                                   2026-07-16T10:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-16T10:00,
                                   2026-07-16T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "Registration",
                                   2026-07-16T13:00,
                                   2026-07-16T14:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-16T14:00,
                                   2026-07-16T15:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-16T16:00,
                                   2026-07-16T17:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "Registration",
                                   2026-07-16T08:00,
                                   2026-07-16T09:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "Registration",
                                   2026-07-16T11:00,
                                   2026-07-16T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "Registration",
                                   2026-07-16T13:00,
                                   2026-07-16T14:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-16T14:00,
                                   2026-07-16T15:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-16T15:30,
                                   2026-07-16T16:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-16T17:00,
                                   2026-07-16T18:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "Registration",
                                   2026-07-16T08:00,
                                   2026-07-16T10:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "Registration",
                                   2026-07-16T12:00,
                                   2026-07-16T13:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-16T14:30,
                                   2026-07-16T15:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-16T16:00,
                                   2026-07-16T18:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "Registration",
                                   2026-07-16T08:00,
                                   2026-07-16T09:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "Registration",
                                   2026-07-16T11:00,
                                   2026-07-16T13:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-16T14:00,
                                   2026-07-16T15:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-16T16:30,
                                   2026-07-16T18:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-16T10:00,
                                   2026-07-16T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-16T14:00,
                                   2026-07-16T14:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-16T15:00,
                                   2026-07-16T18:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-17T09:30,
                                   2026-07-17T10:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-17T10:30,
                                   2026-07-17T11:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-17T11:30,
                                   2026-07-17T12:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-17T13:30,
                                   2026-07-17T16:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-17T09:30,
                                   2026-07-17T10:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-17T10:30,
                                   2026-07-17T11:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-17T12:00,
                                   2026-07-17T12:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-17T14:00,
                                   2026-07-17T16:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-17T17:00,
                                   2026-07-17T17:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-17T09:00,
                                   2026-07-17T09:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-17T10:00,
                                   2026-07-17T10:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-17T11:00,
                                   2026-07-17T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-17T14:00,
                                   2026-07-17T14:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-17T15:00,
                                   2026-07-17T17:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-17T11:00,
                                   2026-07-17T12:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-17T14:00,
                                   2026-07-17T15:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-17T16:30,
                                   2026-07-17T17:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-17T09:00,
                                   2026-07-17T09:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-17T10:00,
                                   2026-07-17T11:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-17T12:00,
                                   2026-07-17T12:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-17T13:30,
                                   2026-07-17T15:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-17T15:30,
                                   2026-07-17T16:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-18T10:00,
                                   2026-07-18T11:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-18T12:00,
                                   2026-07-18T12:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-18T14:30,
                                   2026-07-18T16:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-18T10:00,
                                   2026-07-18T10:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-18T11:30,
                                   2026-07-18T12:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-18T13:30,
                                   2026-07-18T14:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-18T15:00,
                                   2026-07-18T16:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-18T09:30,
                                   2026-07-18T10:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-18T13:30,
                                   2026-07-18T14:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-18T15:30,
                                   2026-07-18T17:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-18T09:30,
                                   2026-07-18T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-18T13:30,
                                   2026-07-18T14:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-18T16:30,
                                   2026-07-18T17:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-18T09:30,
                                   2026-07-18T10:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-18T10:30,
                                   2026-07-18T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-18T14:30,
                                   2026-07-18T15:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-18T16:00,
                                   2026-07-18T16:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-19T10:00,
                                   2026-07-19T10:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2024CONE01],
                                   "WCA Booth",
                                   2026-07-19T11:00,
                                   2026-07-19T11:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-19T10:00,
                                   2026-07-19T10:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2021RUTH02],
                                   "WCA Booth",
                                   2026-07-19T11:00,
                                   2026-07-19T11:30,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2018FOLD01],
                                   "WCA Booth",
                                   2026-07-19T10:30,
                                   2026-07-19T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2019FARD01],
                                   "WCA Booth",
                                   2026-07-19T10:30,
                                   2026-07-19T12:00,
                                   true
                                  )
CreateCompetitionGroupsAssignments([2023GILB07],
                                   "WCA Booth",
                                   2026-07-19T10:00,
                                   2026-07-19T11:00,
                                   true
                                  )