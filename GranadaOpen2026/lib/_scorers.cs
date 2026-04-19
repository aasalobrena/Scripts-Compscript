#include "_constants.cs"
#include "_helpers.cs"

# Args:
# 1: Round
Define("ScramblingCompetingScorers",
	   [PropertyScorer(And(HasProperty(ScramblePropKey({1, Round})),
	   					   (NumberProperty(ScramblePropKey({1, Round})) == GroupNumber())
						  ),
					   -999
					  )
	   ]
	  )

# Args:
# 1: Round
Define("DefaultStaffScorers",
	   [ComputedWeightScorer(If(IsNull(WcaId()),
	   							0,
								1
							   ),
	   						 [JUDGE, RUNNER]
							),
		ComputedWeightScorer((-1 * LengthOfJobs(DefaultStaffCodes())),
							 [JUDGE, RUNNER]
							),
		ComputedWeightScorer(If(CompetingInRound({1, Round}), 
								999,
								-999
							   ),
							 [JUDGE, RUNNER]
							),
		ComputedWeightScorer(If(CompetingIn(EventForRound({1, Round})),
								999,
								-999
							   ),
							 [JUDGE, RUNNER]
							)
	   ]
	  )