#include "_constants.cs"
#include "_helpers.cs"

# Returns AssignmentJob
# Args:
# 1: Number
Define("JudgeJob",
       Job(JUDGE,
           {1, Number},
           eligibility=((NumberProperty(WEIGHT_JUDGE) != -1) && Not(InTeam([DELEGATE_TEAM])))
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
Define("RunnerJob",
       Job(RUNNER,
           {1, Number},
           eligibility=((NumberProperty(WEIGHT_RUNNER) != -1) && Not(InTeam([DELEGATE_TEAM])))
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: Event
Define("ScramblerJob",
       Job(SCRAMBLER, {1, Number}, eligibility=CanScramble({2, Event}))
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: Event
Define("CheckerJob",
       Job(CHECKER, {1, Number}, eligibility=CanScramble({2, Event}))
      )

# Returns AssignmentJob
# Args:
# 1: Number
Define("DelegateJob",
       Job(DELEGATE,
           {1, Number},
           eligibility=(NumberProperty(DELEGATE_CLUSTER) > 0)
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
Define("DataentryJob",
       Job(DATAENTRY,
           {1, Number},
           eligibility=InTeam([DATA_TEAM])
          )
      )
