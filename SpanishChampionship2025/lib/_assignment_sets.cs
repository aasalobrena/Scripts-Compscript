#include "_constants.cs"

Define("GroupsForMulti",
       [Tuple(_333oh, [1]),
        Tuple(_sq1, [2]),
        Tuple(_222, [3])])

Define("MultiSet",
       AssignmentSet("multi",
                     CompetingIn(_333mbf),
                     In(GroupNumber(),
                        Switch(Event(),
                               GroupsForMulti()))))

Define("AuxSet",
       AssignmentSet("aux",
                     (StringProperty(TEAM) == AUX_TEAM),
                     In(GroupNumber(),
                        Switch(Event(),
                               GroupsForMulti()))))

# Args:
# 1: Round
# 2: Number of top people
Define("TopCompetitorsSet",
       AssignmentSet("top",
                     If((RoundNumber({1, Round}) == 1),
                        (PsychSheetPosition(EventForRound({1, Round})) <= {2, Number}),
                        (RoundPosition(PreviousRound({1, Round})) <= {2, Number})),
                     (Stage() == RED),
                     true))

Define("DataentrySet1",
       AssignmentSet("dataentry1",
                     HasRole(DATAENTRY),
                     (Stage() == GREEN)))

Define("DataentrySet2",
       AssignmentSet("dataentry2",
                     HasRole(DATAENTRY),
                     (Stage() == RED)))

Define("OrganizersSet",
       AssignmentSet("organizers",
                     HasRole(ORGANIZER),
                     (Stage() == YELLOW)))

# Args:
# 1: Include Delegates
Define("EveryoneSet", AssignmentSet("everyone", Or({1, Boolean}, Not(IsDelegating())), true))

# Args:
# 1: Round
# 2: Number of top people
# 3: Include Delegates
Define("NormalRoundAssignmentSets",
       Concat(If((RoundId({1, Round}) == "333oh-r1"),
                 [MultiSet(), AuxSet()],
                 []),
              If(In({1, Round}, [_sq1-r1, _222-r1]),
                 [AuxSet()],
                 []),
              [TopCompetitorsSet({1, Round}, {2, Number}),
               DataentrySet1(),
               DataentrySet2(),
               OrganizersSet(),
               EveryoneSet({3, Boolean})]))