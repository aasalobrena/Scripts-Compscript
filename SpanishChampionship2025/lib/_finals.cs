#include "_constants.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "_unavailabilities.cs"

# Args:
# 1: Round
Define("OrderedFinalists",
       Sort<Person, Number>(Persons(CompetingInRound({1, Round})),
                            If((Country() == "ES"), 0, 1),
                            RoundPosition(PreviousRound({1, Round}))))

# Args:
# 1: Round
Define("FinalsSeed", (Index(OrderedFinalists({1, Round})) + 1))

# Args:
# 1: Round
Define("FinalsAssignmentSets",
       [AssignmentSet("odds", Odd(FinalsSeed({1, Round})), (Stage() == RED)),
        AssignmentSet("evens", Even(FinalsSeed({1, Round})), (Stage() == YELLOW))])

# Args:
# 1: Round
Define("FinalsStations", [StationAssignmentRule(true, "ascending", FinalsSeed({1, Round}))])

# Args:
# 1: Round
Define("AssignGroupsFinals",
       AssignGroups({1, Round},
                    FinalsAssignmentSets({1, Round}),
                    [],
                    FinalsStations({1, Round})))

# Args:
# 1: Round
Define("AssignStaffFinals",
       AssignStaff({1, Round},
                   true,
                   Persons(true),
                   [Judges((((Length(Persons(CompetingInRound({1, Round}))) + If(Odd(Length(Persons(CompetingInRound({1, Round})))),
                                                                                 1,
                                                                                 0)) / 2) + 1)),
                    Runners(2),
                    Scramblers(3, EventForRound({1, Round})),
                    Delegates(1),
                    Checkers(1)],
                   VolunteerScorers(EventForRound({1, Round}),
                                    If(In({1, Round}, [_666-r2, _777-r2]),
                                       2025-12-06,
                                       2025-12-08)),
                   unavailable=Unavailable(Arg<Person>())))