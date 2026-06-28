#include "_constants.cs"

Header("Volunteer Workload")
Table(Sort(Persons(In(StringProperty(TYPE), CoreVolunteer())), (0 - LengthOfJobs())),
      [Column("Name", Name()),
       Column("WCA ID", WcaId()),
       Column("Team", ToString(NumberProperty(TEAM))),
       Column("Jobs", NumJobs()),
       Column("Hours", LengthOfJobs())
      ]
     )