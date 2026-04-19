#include "_assignment_sets.cs"
#include "_constants.cs"
#include "_helpers.cs"
#include "_scorers.cs"

# Args:
# 1: Round
# 2: Group number
Define("MarkAssignedScramblers",
       SetProperty(Persons(And((NumJobsInRound({1, Round}) > 0),
	   						   Not(HasProperty(ScramblePropKey({1, Round})))
        					  )
						  ),
        		   ScramblePropKey({1, Round}),
				   {2, Number}
				  )
	  )

# Args:
# 1: Round
# 2: Group number
# 3: Number of scramblers
Define("AssignScramblers",
	   Tuple(AssignStaff({1, Round},
						 (GroupNumber() == {2, Number}),
						 If((Length(Persons(CanScrambleEvent(EventForRound({1, Round})))) >= ({3, Number} * Length(Groups({1, Round})))),
							Persons(And(CanScrambleEvent(EventForRound({1, Round})),
										(NumJobsInRound({1, Round}, SCRAMBLER) == 0)
									   )
								   ),
							Persons(And(CanScrambleEventRelaxed(EventForRound({1, Round}),
																({3, Number} * Length(Groups({1, Round}))),
																false
															   ),
										(NumJobsInRound({1, Round}, SCRAMBLER) == 0)
									   )
								   )
						   ),
						 [Job(SCRAMBLER, {3, Number})],
						 DefaultStaffScorers({1, Round})
						),
			 MarkAssignedScramblers({1, Round},
			 						{2, Number}
								   )
			)
	  )

# Args:
# 1: Round
# 2: Group number
# 3: Number of scramblers
Define("AssignScramblersWithMbf",
	   Tuple(AssignStaff({1, Round},
						 (GroupNumber() == {2, Number}),
						 If((Length(Persons(And(CanScrambleEvent(EventForRound({1, Round})),
						 						HasMbfAssignments()
											   )
										   )
								   ) >= ({3, Number} * Length(Groups({1, Round})))),
							Persons(And(CanScrambleEvent(EventForRound({1, Round})),
										(NumJobsInRound({1, Round}, SCRAMBLER) == 0),
										Not(HasMbfAssignments())
									   )
								   ),
							Persons(And(CanScrambleEventRelaxed(EventForRound({1, Round}),
																({3, Number} * Length(Groups({1, Round}))),
																true
															   ),
										(NumJobsInRound({1, Round},
														SCRAMBLER
													   ) == 0),
										Not(HasMbfAssignments())
									   )
								   )
						   ),
						   [Job(SCRAMBLER, {3, Number})],
						   DefaultStaffScorers({1, Round})
						),
			 MarkAssignedScramblers({1, Round},
			 						{2, Number}
								   )
			)
	  )

# Args:
# 1: Round
Define("ReAssignScramblers",
	   Map(Groups({1, Round}),
		   ManuallyAssign(Persons((NumberProperty(ScramblePropKey({1, Round})) == GroupNumber())),
						  {1, Round},
						  SALON,
						  GroupNumber(),
						  STAFFSCRAMBLER
						 )
		  )
	  )

# Args:
# 1: Round
Define("AssignCompetitors",
	   AssignGroups({1, Round},
					DefaultAssignmentSets({1, Round}),
					ScramblingCompetingScorers({1, Round}),
					[StationAssignmentRule(true,
										   "ascending",
										   If((RoundNumber({1, Round}) == 1),
										   	  PsychSheetPosition(EventForRound({1, Round})),
											  RoundPosition(RoundForEvent((RoundNumber({1, Round}) - 1),
											  							  EventForRound({1, Round})
																		 )
														   )
											 )
										  )
					],
					overwrite=true
				   )
	  )