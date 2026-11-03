#include "_constants.cs"
#include "_helpers.cs"

# Returns Boolean(Person)
# Args:
# 1: Array<Round>
Define("CompetesOrVolunteersInRound",
       If((Length({1, Array<Round>}) > 0),
          (CompetingInRound(At({1, Array<Round>}, 0)) || (NumJobsInRound(At({1, Array<Round>}, 0)) > 0)),
          false
         )
      )

# Returns AssignmentSet
# Args:
# 1: Array<Round>: Side Round
# 2: Array<Number>: Groups to compete in Main Round
# 3: Round: Main Round
# 4: Number: Number of top competitors per group
# 5: Boolean: Featured
Define("TopSideSet",
       AssignmentSet((TOP_SIDE_SET + ToString({5, Boolean})),
                     (IsInTop({3, Round}, {4, Number}) && CompetesOrVolunteersInRound({1, Array<Round>})),
                     ((Stage() == BIZKAIA_STAGE) && In(GroupNumber(), {2, Array<Number>})),
                     {5, Boolean}
                    )
      )

# Returns AssignmentSet
# Args:
# 1: Array<Round>: Side Round
# 2: Array<Number>: Groups to compete in Main Round
# 3: String: Stage
Define("SideSet",
       AssignmentSet((SIDE_SET + {3, String}),
                     CompetesOrVolunteersInRound({1, Array<Round>}),
                     ((Stage() == {3, String}) && In(GroupNumber(), {2, Array<Number>}))
                    )
      )

# Returns AssignmentSet
# Args:
# 1: Round
# 2: Number: Number of top competitors per group
# 3: Boolean: Featured
Define("TopSet",
       AssignmentSet((TOP_SET + ToString({3, Boolean})),
                     IsInTop({1, Round}, {2, Number}),
                     (Stage() == BIZKAIA_STAGE),
                     {3, Boolean}
                    )
      )

# Returns AssignmentSet
# Args:
# 1: Date
# 2: Array<Number>: Delegate clusters
Define("DelegatesSet",
       AssignmentSet((DELEGATES_SET + ToString(At({2, Array<Number>}, 0))),
                     InDelegateCluster({2, Array<Number>}),
                     (Stage() == DelegateStage({1, Date}, At({2, Array<Number>}, 0)))
                    )
      )

# Returns AssignmentSet
# Args:
# 1: String: Stage
Define("StreamingSet",
       AssignmentSet((STREAMING_SET + {1, String}),
                     InTeam([STREAMING_TEAM]),
                     (Stage() == {1, String})
                    )
      )

# Returns AssignmentSet
Define("EveryoneSet",
       AssignmentSet(EVERYONE_SET,
                     true,
                     Not(In(Stage(), [BIZKAIA_STAGE, MAIN_ROOM]))
                    )
      )
