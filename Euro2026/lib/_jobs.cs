#include "_constants.cs"
#include "_eligible_scramblers.cs"

# Args:
# 1: Round
# 2: Number of judges
# 3: Number of runners
# 4: Number of scramblers
# 5: Number of table managers
# 6: Number of checkers
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
            eligibility=CanScramble(EventForRound({1, Round}))
           ),
        Job(TABLEMANAGER,
            {5, Number},
            eligibility=In(TABLEMANAGER, ArrayProperty(TASKS))
           ),
        Job(CHECKER,
            {6, Number},
            eligibility=CanScramble(EventForRound({1, Round}))
           )
       ]
      )

# Args:
# 1: Round
Define("NormalRoundJobs", DefaultJobs({1, Round}, 14, 3, 3, 1, 0))