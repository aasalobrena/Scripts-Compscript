#include "_constants.cs"
#include "_helpers.cs"

# Args:
# 1: Round
Define("Judges",
       Job(JUDGE,
           CompetitorsPerGroup({1, Round}),
           eligibility=CanStaffEvent(EventForRound({1, Round}))
          )
      )

# Args:
# 1: Round
Define("Runners",
       Job(RUNNER,
           If(IsFinal({1, Round}),
              2,
              3
             ),
           eligibility=CanStaffEvent(EventForRound({1, Round}))
          )
      )

# Args:
# 1: Round
Define("DefaultJobs",
       [Judges({1, Round}),
		Runners({1, Round}),
		Job(DELEGATE,
                1,
                eligibility=Or(HasRole(DELEGATE),
                               HasRole(TRAINEE)
                              )
               )
	 ]
      )

# Args:
# 1: Round
Define("MbfJobs",
	   [Judges({1, Round}),
		Runners({1, Round})
	   ]
      )

# Args:
# 1: Round
# 2: Number of scramblers
Define("FinalJobs",
	   [Judges({1, Round}),
	    Runners({1, Round}),
          Job(SCRAMBLER,
              {2, Number},
              eligibility=ScramblesFinal({1, Round},
                                         {2, Number}
                                        )
             )
	   ]
      )