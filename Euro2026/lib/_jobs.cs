#include "_constants.cs"
#include "_eligible_scramblers.cs"

# Args:
# 1: Round
# 2: Number of judges
# 3: Number of runners
# 4: Number of scramblers
Define("DefaultJobs",
       [Job(JUDGE,
            {2, Number},
            eligibility=In(JUDGE, ArrayProperty(TASKS))
           ),
        Job(RUNNER,
            {3, Number},
            eligibility=In(RUNNER, ArrayProperty(TASKS))
           ),
        Job(SCRAMBLER,
            {4, Number},
            eligibility=(CanScramble(EventForRound({1, Round})) && In(SCRAMBLER, ArrayProperty(TASKS)))
           )
       ]
      )

# Args:
# 1: Round
Define("NormalRoundJobs", DefaultJobs({1, Round}, 14, 3, 3))

# Args:
# 1: Round
# 2: Time result for scrambler scorer
# 3: Weight for scrambler scorer
Define("DefaultStaffScorers",
       [JobCountScorer(-1),                             # minimize total work per person
        SameJobScorer(60, -5, 4),                       # prefer same job within 60min, penalty after 4
        ConsecutiveJobScorer(45, -3, 0),                # mild reward for consecutive jobs (45min window)
        ConsecutiveJobScorer(100, -1000, 0),            # strong reward over 100min window
        MismatchedStationScorer(-10),                   # penalize station changes
        SolvingSpeedScorer(Switch({1, Round}, EventsToScramblingEvents()),
                           {2, AttemptResult},
                           {3, Number},
                           [SCRAMBLER]),                # prefer faster scramblers
        FollowingGroupScorer(-50)                       # penalize staffing right after competing
       ]
      )