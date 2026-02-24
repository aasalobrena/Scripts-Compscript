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
       [PriorAssignmentScorer(-5, -1, Midnight({2, Date})),
        PriorAssignmentScorer(-2, 0, 2026-03-07T00:00),
        SameJobScorer(60, -5, 4, jobs=StandardJobNames()),
        ConsecutiveJobScorer(90, -3, 0, jobs=StandardJobNames()),
        ConsecutiveJobScorer(30, -5, 0, jobs=["scrambler"]),
        SolvingSpeedScorer(Switch({1, Event}, EventsToScramblingEvents()),
                           Switch(Switch({1, Event}, EventsToScramblingEvents()), ScrambleLimits()),
                           Switch({1, Event}, ScrambleSpeedWeight()),
                           ["scrambler"]
                          ),
        ConditionalScorer(CompetingIn({1, Event}), true, (Arg<String>() == "delegate"), true, 100),
        PersonPropertyScorer(HasRole(ORGANIZER), -100)
       ]
      )