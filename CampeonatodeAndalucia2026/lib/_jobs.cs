#include "_constants.cs"
#include "_eligible_scramblers.cs"

Define("EligibleVolunteer",
       And(Registered(),
           Not(HasRole(ORGANIZER)),
           Not(HasRole(DELEGATE)),
           Not(IsNull(WcaId())),
           Not(IsPossibleNoShow()),
           (WcaId() != "2013ROCA01")
          )
      )

Define("EligibleRunner",
       And(EligibleVolunteer(),
           (Age() < 45)
          )
      )

# Args:
# 1: Event
Define("EligibleScrambler",
       And(EligibleVolunteer(),
           CompetingIn({1, Event}),
           CanScramble({1, Event})
          )
      )

# Args:
# 1: Number of judges
Define("Judges",
       Job("judge",
           {1, Number},
           eligibility=EligibleVolunteer()
          )
      )

# Args:
# 1: Number of runners
Define("Runners",
       Job("runner",
           {1, Number},
           eligibility=EligibleRunner()
          )
      )

# Args:
# 1: Number of scramblers
# 2: Event
Define("Scramblers",
       Job("scrambler",
           {1, Number},
           eligibility=EligibleScrambler({2, Event})
          )
      )

Define("Delegates",
       Job("delegate",
           1,
           eligibility=HasRole(DELEGATE)
          )
      )