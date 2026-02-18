#include "_constants.cs"
#include "_eligible_scramblers.cs"

Define("EligibleVolunteer",
       And(Registered(),
           Not(HasRole(ORGANIZER)),
           Not(HasRole(DELEGATE)),
           Not(In(StringProperty(TEAM), [DATA_TEAM, AES_TEAM])),
           Not(IsNull(WcaId()))))

Define("EligibleJudge",
       And(EligibleVolunteer(),
           Not(In("judge", ArrayProperty(NO_TASKS)))))

Define("EligibleRunner",
       And(EligibleVolunteer(),
           Not(In("runner", ArrayProperty(NO_TASKS))),
           (Age() < 30)))

# Args:
# 1: Event
Define("EligibleScrambler",
       And(EligibleVolunteer(),
           Or(CompetingIn({1, Event}),
              (StringProperty(TEAM) == AUX_TEAM)),
           Not(In("scrambler", ArrayProperty(NO_TASKS))),
           CanScramble({1, Event})))

# Args:
# 1: Number of judges
Define("Judges",
       Job("judge",
           {1, Number},
           eligibility=EligibleJudge()))

# Args:
# 1: Number of runners
Define("Runners",
       Job("runner",
           {1, Number},
           eligibility=EligibleRunner()))

# Args:
# 1: Number of scramblers
# 2: Event
Define("Scramblers",
       Job("scrambler",
           {1, Number},
           eligibility=EligibleScrambler({2, Event})))

# Args:
# 1: Number of delegates
Define("Delegates", Job("delegate", {1, Number}, eligibility=IsDelegating()))

# Args:
# 1: Number of checkers
Define("Checkers", Job("Checker", {1, Number}, eligibility=IsDelegating()))