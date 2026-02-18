# Volunteers
#define ORGANIZER "organizer"
#define DELEGATE "delegate"

Define("IsDelegating",
       And(HasRole(DELEGATE),
           Not(HasRole(ORGANIZER))
          )
      )

# Rooms
#define PISTA "Pista"

# Stages
#define GREEN "Verde"
#define WHITE "Blanco"

Define("Stages", [GREEN, WHITE])