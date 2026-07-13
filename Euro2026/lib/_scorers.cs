#include "_constants.cs"
#include "_eligible_scramblers.cs"

# Args:
# 1: Round
# 2: Time result for scrambler scorer
# 3: Weight for scrambler scorer
Define("DefaultStaffScorers",
       [JobCountScorer(-50),                            # minimize total work per person
        SameJobScorer(60, -5, 4),                       # prefer same job within 60min, penalty after 4
        ConsecutiveJobScorer(45, -3, 0),                # mild reward for consecutive jobs (45min window)
        ConsecutiveJobScorer(100, -1000, 0),            # strong reward over 100min window
        SolvingSpeedScorer(Switch(EventForRound({1, Round}), EventsToScramblingEvents()),
                           {2, AttemptResult},
                           {3, Number},
                           [SCRAMBLER]),                # prefer faster scramblers
        FollowingGroupScorer(-50)                       # penalize staffing right after competing
       ]
      )

# Args:
# 1: Round
# 2: Time result for scrambler scorer
Define("FinalsScorers",
       [ConditionalScorer((StringProperty(DELEGATE) == DELEGATE),
                          true,
                          true,
                          true,
                          999
                         ),
        ConditionalScorer((StringProperty(DELEGATE) == JUNIOR),
                          true,
                          true,
                          true,
                          99
                         ),
        ConditionalScorer((StringProperty(DELEGATE) == TRAINEE),
                          true,
                          true,
                          true,
                          9
                         ),
        SolvingSpeedScorer(Switch(EventForRound({1, Round}), EventsToScramblingEvents()),
                           {2, AttemptResult},
                           9999,
                           [SCRAMBLER]),
        FollowingGroupScorer(-9999)
       ]
      )
