#include "_constants.cs"

Header("Volunteer Workload (Number)")
Table(Sort(Persons(In(StringProperty(TYPE), CoreVolunteer())), (0 - NumJobs())),
      [Column("Name", Name()),
       Column("WCA ID", WcaId()),
       Column("Team", ToString(NumberProperty(TEAM))),
       Column("Jobs", NumJobs())
      ]
     )

Header("Volunteer Workload (Length)")
Table(Sort(Persons(In(StringProperty(TYPE), CoreVolunteer())), (0 - LengthOfJobs())),
      [Column("Name", Name()),
       Column("WCA ID", WcaId()),
       Column("Team", ToString(NumberProperty(TEAM))),
       Column("Jobs", LengthOfJobs())
      ]
     )