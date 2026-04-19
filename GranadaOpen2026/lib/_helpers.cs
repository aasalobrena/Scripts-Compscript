#include "_constants.cs"

Define("CompetitorsPerGroup",
	If((Mod(Length(Persons(CompetingInRound({1, Round}))), Length(Groups({1, Round}))) == 0),
		(Length(Persons(CompetingInRound({1, Round}))) / Length(Groups({1, Round}))),
		(IntDivide(Length(Persons(CompetingInRound({1, Round}))), Length(Groups({1, Round}))) + 1)
	)
)

# Args:
# 1: Round
Define("ScramblePropKey", 
       ("scrambles-" + RoundId({1, Round}))
      )

# Useful Booleans(Person)

Define("MbfJudges", [2015SANC18, 2018MORA17, 2023OSOR03])
Define("HasMbfAssignments", Or(CompetingIn(_333mbf), In(MbfJudges())))
Define("ChillsEvent", (StringProperty(CHILL) == EventId({1, Event})))
Define("CanStaff", And(Registered(), IsCompeting(), Not(HasRole(DELEGATE)), Not(HasRole(TRAINEE)), Not(HasRole(ORGANIZER)), Not(HasRole(STAFFDATAENTRY)), Not(In(WcaId(), UkuIds()))))
Define("CanStaffEvent", And(CanStaff(), Not(ChillsEvent({1, Event}))))
Define("CanDataEvent", And(Not(ChillsEvent({1, Event})), HasRole(STAFFDATAENTRY)))
Define("IsInTop25Psych", And(CompetingIn({1, Event}), (PsychSheetPosition({1, Event}) < (0.25 * Length(Persons(CompetingIn({1, Event})))))))
Define("CanScrambleEvent", And(CanStaffEvent({1, Event}), Or(IsInTop25Psych({1, Event}), And(Or((EventId({1, Event}) == "333bf"), (EventId({1, Event}) == "333oh")), IsInTop25Psych(_333)))))
Define("CanScrambleEventRelaxed", In(Slice(Sort(Persons(And(CanStaffEvent({1, Event}), CompetingIn({1, Event}), If({3, Boolean}, Not(HasMbfAssignments()), true))), If(Or((EventId({1, Event}) == "333bf"), (EventId({1, Event}) == "333oh")), PsychSheetPosition(_333), PsychSheetPosition({1, Event}))), 0, {2, Number})))
Define("IsTopScrambler", (NumberProperty(ScramblePropKey({1, Round})) == Length(Groups({1, Round}))))
# PROD
Define("IsTopCompetitor", If((RoundNumber({1, Round}) == 1), (PsychSheetPosition(EventForRound({1, Round})) <= CompetitorsPerGroup({1, Round})), (RoundPosition({1, Round}) <= CompetitorsPerGroup({1, Round}))))
Define("ScramblesFinal", And((Length(Persons(CompetingInRound({1, Round}))) < RoundPosition(RoundForEvent((RoundNumber({1, Round}) - 1), EventForRound({1, Round})))), (RoundPosition(RoundForEvent((RoundNumber({1, Round}) - 1), EventForRound({1, Round}))) <= (Length(Persons(CompetingInRound({1, Round}))) + {2, Number}))))
# DEV
# Define("IsTopCompetitor", (PsychSheetPosition(EventForRound({1, Round})) <= CompetitorsPerGroup({1, Round})))
# Define("ScramblesFinal", And((Length(Persons(CompetingInRound({1, Round}))) < PsychSheetPosition(EventForRound({1, Round}))), (PsychSheetPosition(EventForRound({1, Round})) <= (Length(Persons(CompetingInRound({1, Round}))) + {2, Number}))))
