# Args:
# 1: Person
Define("Unavailable",
       Switch({1, Person},
              [Tuple(2023KATE03, [UnavailableBetween(2026-03-07T09:00, 2026-03-07T10:30)]),   # Helena Martín Katerji
               Tuple(2023KATE04, [UnavailableBetween(2026-03-07T09:00, 2026-03-07T10:30)])    # Ismael Martín Katerji
              ],
              defaultValue=[])
      )