Define("ScrambleLimits",
       [Tuple(_333,     30s),
        Tuple(_222,     12s),
        Tuple(_444,   1:30s),
        Tuple(_555,   2:00s),
        Tuple(_666,   5:00s),
        Tuple(_777,   6:00s),
        Tuple(_clock,   12s),
        Tuple(_minx,  1:30s),
        Tuple(_pyram,   12s),
        Tuple(_skewb,   12s),
        Tuple(_sq1,     30s)
       ]
      )

Define("EventsToScramblingEvents",
       [Tuple(_333,    _333),
        Tuple(_222,    _222),
        Tuple(_444,    _444),
        Tuple(_555,    _555),
        Tuple(_666,    _666),
        Tuple(_777,    _777),
        Tuple(_333bf,  _333),
        Tuple(_333oh,  _333),
        Tuple(_clock,  _clock),
        Tuple(_minx,   _minx),
        Tuple(_pyram,  _pyram),
        Tuple(_skewb,  _skewb),
        Tuple(_sq1,    _sq1),
        Tuple(_444bf,  _444),
        Tuple(_555bf,  _555),
        Tuple(_333mbf, _333)
       ]
      )

# Args:
# 1: Event
Define("CanScramble",
       ((PersonalBest(Switch({1, Event},
                            EventsToScramblingEvents()
                           )
                    ) <
                     Switch(Switch({1, Event},
                                   EventsToScramblingEvents()
                                  ),
                            ScrambleLimits()
                           )) &&
                             In(EventId({1, Event}),
                                ArrayProperty("scramble-events")
                               )
       )
      )