#include "_constants.cs"
#include "_helpers.cs"

# Returns AssignmentJob
# Args:
# 1: Number
Define("JudgeJob",
       Job(JUDGE,
           {1, Number},
           eligibility=((NumberProperty(WEIGHT_JUDGE) != -1) && Not(InTeam([DELEGATE_TEAM, DATA_TEAM]))),
           groupFilter=(Stage() != MAIN_ROOM)
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
Define("RunnerJob",
       Job(RUNNER,
           {1, Number},
           eligibility=((NumberProperty(WEIGHT_RUNNER) != -1) && Not(InTeam([DELEGATE_TEAM, DATA_TEAM]))),
           groupFilter=(Stage() != MAIN_ROOM)
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: Event
Define("ScramblerJob",
       Job(SCRAMBLER,
           {1, Number},
           eligibility=CanScramble({2, Event}),
           groupFilter=(Stage() != MAIN_ROOM)
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: Event
Define("CheckerJob",
       Job(CHECKER,
           {1, Number},
           eligibility=CanScramble({2, Event}),
           groupFilter=(Stage() != MAIN_ROOM)
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: String: Stage
# 3: Round
Define("DelegateJob",
       Job(DELEGATE,
           {1, Number},
           eligibility=If((RoundNumber({3, Round}) == 1),
                          (DelegateStage(Date(RoundStartTime({3, Round})),
                                         NumberProperty(If((StagesPerRound({3, Round}) == 3),
                                                           DELEGATE_CLUSTER,
                                                           DELEGATE_CLUSTER_EXTRA
                                                          )
                                                       )
                                        ) == {2, String}),
                          InTeam([DELEGATE_TEAM])
                         ),
           groupFilter=(Stage() == {2, String})
          )
      )

# Returns AssignmentJob
# Args:
# 1: Number
# 2: String: Stage
Define("DataentryJob",
       Job(DATAENTRY,
           {1, Number},
           eligibility=InTeam([DATA_TEAM]),
           groupFilter=(Stage() == {2, String})
          )
      )
