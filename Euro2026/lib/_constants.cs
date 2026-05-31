# Rooms
#define HALL123 "Hall 123"
#define HALL5 "Hall 5"
#define SIDEROOM "Side Room"

# Stages
#define ORANGE "Orange"
#define BLUE "Blue"
#define GREEN "Green"
#define RED "Red"
#define YELLOW "Yellow"

Define("Hall123Stages", [GREEN,  ORANGE, BLUE])
Define("Hall5Stages",   [YELLOW, RED])
Define("FinalsStages",  [GREEN,  ORANGE])
Define("AllStages",     Concat(Hall123Stages(), Hall5Stages()))

# Properties
#define PRETEAM "preteam"
#define TASKS "tasks"
#define TEAM "team"
#define TYPE "type"
#define UNAVAILABILITY "unavailability"

#define DATA "data"
#define LEADER "leader"
#define SIDE "side"
#define STAGE "stage"

# Jobs and roles
#define DATAENTRY "staff-dataentry"
#define JUDGE "judge"
#define RUNNER "runner"
#define SCRAMBLER "scrambler"