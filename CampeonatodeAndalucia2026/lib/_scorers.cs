#include "_constants.cs"
#include "_eligible_scramblers.cs"

Define("ScrambleSpeedWeight",
       [Tuple(_333, 3),
        Tuple(_222, 3),
        Tuple(_444, 5),
        Tuple(_555, 5),
        Tuple(_666, 8),
        Tuple(_777, 8),
        Tuple(_333bf, 1),
        Tuple(_333oh, 1),
        Tuple(_clock, 5),
        Tuple(_minx, 8),
        Tuple(_pyram, 3),
        Tuple(_skewb, 3),
        Tuple(_sq1, 5)
       ]
      )

Define("StandardJobNames", ["judge", "scrambler", "runner", "delegate"])

# Args:
# 1: Event
# 2: Date
Define("VolunteerScorers",
       [SolvingSpeedScorer(Switch({1, Event}, EventsToScramblingEvents()),
                           Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                           Switch({1, Event}, ScrambleSpeedWeight()),
                           ["scrambler"]
                          ),
        ConditionalScorer(And(CompetingIn({1, Event}),
                              Not(CanScramble({1, Event}))),
                          true,
                          (Arg<String>() != "delegate"),
                          true,
                          50
                         ),
        ComputedWeightScorer(Length(RegisteredEvents()), ["judge", "runner", "scrambler"]),
        PersonPropertyScorer(HasRole(ORGANIZER), -100)
       ]
      )