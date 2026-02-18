Table(
  Sort(Persons(Registered()), (LengthOfJobs() / LengthOfJobs("competitor"))),
  [Column("Name", Name()), Column("Ratio", (LengthOfJobs() / LengthOfJobs("competitor")))]
)
  
  
Table(
  Sort(Persons(Registered()), LengthOfJobs()),
  [Column("Name", Name()), Column("Horas", LengthOfJobs())]
)