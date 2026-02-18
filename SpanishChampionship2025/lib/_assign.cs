#include "_constants.cs"
#include "_assignment_sets.cs"
#include "_jobs.cs"
#include "_scorers.cs"
#include "_unavailabilities.cs"

# Args:
# 1: Round
Define("AssignGroupsAux", AssignGroups({1, Round}, [AssignmentSet("everyone", true, true)], [], []))

Define("AuxJobsNames",
       [Tuple(_444bf, [Tuple("staff-judge", 444bf_JUDGE),
                          Tuple("staff-scrambler", 444bf_SCRAMBLER),
                          Tuple("staff-delegate", 444bf_DELEGATE)]),
        Tuple(_555bf, [Tuple("staff-judge", 555bf_JUDGE),
                          Tuple("staff-scrambler", 555bf_SCRAMBLER),
                          Tuple("staff-delegate", 555bf_DELEGATE)])])

# Args:
# 1: Round
Define("AssignStaffAux",
       Map(["staff-judge", "staff-scrambler", "staff-delegate"],
           ManuallyAssign(Persons(In(Switch(Arg<String>(), Switch(EventForRound({1, Round}), AuxJobsNames())),
                                            ArrayProperty(AUX_TASKS))),
                          {1, Round},
                          AUX,
                          1,
                          Arg<String>())))

# Args:
# 1: Round
# 2: Number of top people
# 3: Assign Delegates
Define("AssignGroupsStages",
       AssignGroups({1, Round},
                    NormalRoundAssignmentSets({1, Round}, {2, Number}, {3, Boolean}), [], []))

# Args:
# 1: Round
# 2: Date of the round
# 3: Number of judges
# 4: Number of runners
# 5: Number of scramblers
# 6: Number of delegates
Define("AssignStaffStages",
       AssignStaff({1, Round},
                   true,
                   Persons(true),
                   [Judges({3, Number}),
                    Runners({4, Number}),
                    Scramblers({5, Number}, EventForRound({1, Round})),
                    Delegates({6, Number})],
                   VolunteerScorers(EventForRound({1, Round}), {2, Date}),
                   unavailable=Unavailable(Arg<Person>())))

# Args:
# 1: Round
Define("TopCompetitorsPerRound", (Length(Filter(Groups({1, Round}), (Stage() == RED))) * 4))