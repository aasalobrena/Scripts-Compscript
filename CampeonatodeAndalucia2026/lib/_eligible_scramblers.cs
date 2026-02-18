Define("ScrambleLimits",
       [Tuple(_333, 20s),
        Tuple(_222, 8s),
        Tuple(_444, 1:00s),
        Tuple(_555, 1:30s),
        Tuple(_666, 2:45s),
        Tuple(_777, 4:30s),
        Tuple(_clock, 10s),
        Tuple(_minx, 1:30s),
        Tuple(_pyram, 8s),
        Tuple(_skewb, 8s),
        Tuple(_sq1, 20s)
       ]
      )

Define("EventsToScramblingEvents",
       [Tuple(_333, _333),
        Tuple(_222, _222),
        Tuple(_444, _444),
        Tuple(_555, _555),
        Tuple(_666, _666),
        Tuple(_777, _777),
        Tuple(_333bf, _333),
        Tuple(_333oh, _333),
        Tuple(_clock, _clock),
        Tuple(_minx, _minx),
        Tuple(_pyram, _pyram),
        Tuple(_skewb, _skewb),
        Tuple(_sq1, _sq1)
       ]
      )

# Args:
# 1: Event
Define("CanScramble",
       (PersonalBest(Switch({1, Event},
                            EventsToScramblingEvents()
                           )
                    ) <
                     Switch(Switch({1, Event},
                                   EventsToScramblingEvents()
                                  ),
                            ScrambleLimits()
                           )
       )
      )