#include "../lib/_constants.cs"
#include "../lib/_finals.cs"

AssignGroups(_333-r4,
             [AssignmentSet("foreigners", (FinalsSeed(_333-r4) > 16), (GroupNumber() == 1)),
              AssignmentSet("16", (FinalsSeed(_333-r4) == 16), ((GroupNumber() == 2) && (Stage() == YELLOW))),
              AssignmentSet("14", (FinalsSeed(_333-r4) == 14), ((GroupNumber() == 3) && (Stage() == YELLOW))),
              AssignmentSet("12", (FinalsSeed(_333-r4) == 12), ((GroupNumber() == 4) && (Stage() == YELLOW))),
              AssignmentSet("10", (FinalsSeed(_333-r4) == 10), ((GroupNumber() == 5) && (Stage() == YELLOW))),
              AssignmentSet("8", (FinalsSeed(_333-r4) == 8), ((GroupNumber() == 6) && (Stage() == YELLOW))),
              AssignmentSet("6", (FinalsSeed(_333-r4) == 6), ((GroupNumber() == 7) && (Stage() == YELLOW))),
              AssignmentSet("4", (FinalsSeed(_333-r4) == 4), ((GroupNumber() == 8) && (Stage() == YELLOW))),
              AssignmentSet("2", (FinalsSeed(_333-r4) == 2), ((GroupNumber() == 9) && (Stage() == YELLOW))),
              AssignmentSet("15", (FinalsSeed(_333-r4) == 15), ((GroupNumber() == 2) && (Stage() == RED))),
              AssignmentSet("13", (FinalsSeed(_333-r4) == 13), ((GroupNumber() == 3) && (Stage() == RED))),
              AssignmentSet("11", (FinalsSeed(_333-r4) == 11), ((GroupNumber() == 4) && (Stage() == RED))),
              AssignmentSet("9", (FinalsSeed(_333-r4) == 9), ((GroupNumber() == 5) && (Stage() == RED))),
              AssignmentSet("7", (FinalsSeed(_333-r4) == 7), ((GroupNumber() == 6) && (Stage() == RED))),
              AssignmentSet("5", (FinalsSeed(_333-r4) == 5), ((GroupNumber() == 7) && (Stage() == RED))),
              AssignmentSet("3", (FinalsSeed(_333-r4) == 3), ((GroupNumber() == 8) && (Stage() == RED))),
              AssignmentSet("1", (FinalsSeed(_333-r4) == 1), ((GroupNumber() == 9) && (Stage() == RED)))],
              stationRules=[StationAssignmentRule((GroupNumber() == 1), "ascending", FinalsSeed(_333-r4))])

AssignStaff(_333-r4,
            (GroupNumber() == 1),
            Persons(Not(CompetingInRound(_333-r4))),
            [Judges(10),
             Runners(2),
             Scramblers(2, _333),
             Delegates(1),
             Checkers(1)],
            VolunteerScorers(_333, 2025-12-08),
            unavailable=Unavailable(Arg<Person>()))

Map([2, 3, 4, 5, 6, 7, 8, 9],
    All(ManuallyAssign([2019GEAA01], _333-r4, RED, Arg<Number>(), "staff-judge"),
        ManuallyAssign([2016PERE44], _333-r4, YELLOW, Arg<Number>(), "staff-judge"),
        ManuallyAssign([2015ROYC01], _333-r4, RED, Arg<Number>(), "staff-runner"),
        ManuallyAssign([2017NICO01], _333-r4, YELLOW, Arg<Number>(), "staff-runner"),
        ManuallyAssign([2015GIME02], _333-r4, RED, Arg<Number>(), "staff-scrambler"),
        ManuallyAssign([2021CARB01], _333-r4, YELLOW, Arg<Number>(), "staff-scrambler"),
        ManuallyAssign([2016LOPE37], _333-r4, RED, Arg<Number>(), "staff-Checker"),
        ManuallyAssign([2015SANC18], _333-r4, YELLOW, Arg<Number>(), "staff-Checker")))