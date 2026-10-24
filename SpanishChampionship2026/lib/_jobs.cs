#include "_constants.cs"
#include "_helpers.cs"

# Returns AssignmentJob
# Args:
# 1: Number
Define("JudgeJob",
       Job(JUDGE, {1, Number}, eligibility=CanJudge())
      )

# Returns AssignmentJob
# Args:
# 1: Number
Define("RunnerJob",
       Job(RUNNER, {1, Number}, eligibility=CanRun())
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
Define("DelegateJob",
       Job(DELEGATE, {1, Number}, eligibility=CanDelegate())
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: Stage
# 3: Date
Define("StageDelegateJob",
       Job(DELEGATE,
           {1, Number},
           eligibility=(DelegateStage({3, Date}, NumberProperty(DELEGATE_CLUSTER)) == {2, String})
          )
      )
