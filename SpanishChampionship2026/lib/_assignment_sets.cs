#include "_constants.cs"
#include "_helpers.cs"

# Returns AssignmentSet
Define("EveryoneSet",
       AssignmentSet(EVERYONE_SET,
                     true,
                     (Stage() != BIZKAIA_STAGE)
                    )
      )

# Returns AssignmentSet
Define("CoreSet",
       AssignmentSet(CORE_SET,
                     InTeam([CORE_TEAM]),
                     (Stage() == GIPUZKOA_STAGE)
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
Define("AESSet",
       AssignmentSet(AES_SET,
                     InTeam([AES_TEAM]),
                     (Stage() == GIPUZKOA_STAGE)
                    )
      )

# Returns AssignmentSet
Define("DataSet",
       AssignmentSet(DATA_SET,
                     InTeam([DATA_TEAM]),
                     (Stage() == GIPUZKOA_STAGE)
                    )
      )

# Returns AssignmentSet
Define("StreamingSet",
       AssignmentSet(STREAMING_SET,
                     InTeam([STREAMING_TEAM]),
                     (Stage() == ARABA_STAGE)
                    )
      )

# Returns AssignmentSet
# Args:
# 1: Round
# 2: Number: Number of featured competitors per group
Define("FeaturedSet",
       AssignmentSet(FEATURED_SET,
                     (Seed({1, Round}) <= NumberPerGroupToPerRound({1, Round}, {2, Number})),
                     (Stage() == BIZKAIA_STAGE),
                     true
                    )
      )

# Returns AssignmentSet
# Args:
# 1: Round
# 2: Number: Number of top competitors per group
Define("TopSet",
       AssignmentSet(TOP_SET,
                     (Seed({1, Round}) <= NumberPerGroupToPerRound({1, Round}, {2, Number})),
                     (Stage() == BIZKAIA_STAGE)
                    )
      )

# Returns Array<AssignmentSet>
# Args:
# 1: Round
# 2: Number: Number of featured competitors per group
# 3: Number: Number of top competitors per group
Define("FirstRoundAssignmentSets",
       [FeaturedSet({1, Round}, {2, Number}),
        TopSet({1, Round}, {3, Number}),
        CoreSet(),
        DelegatesSet(RoundDate({1, Round}), [1, 2]),
        DelegatesSet(RoundDate({1, Round}), [3]),
        DelegatesSet(RoundDate({1, Round}), [4]),
        AESSet(),
        DataSet(),
        StreamingSet(),
        EveryoneSet()
       ]
      )
