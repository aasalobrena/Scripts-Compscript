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
#define SCRAMBLEEVENTS "scramble-events"
#define PRETEAM "preteam"
#define SIDETASKS "side-tasks"
#define TASKS "tasks"
#define TEAM "team"
#define TYPE "type"
#define UNAVAILABILITY "unavailability"

#define DATA "data"
#define FM "fm"
#define LEADER "leader"
#define MBF "mbf"
#define MBF11 "mbf11"
#define MBF12 "mbf12"
#define MBF21 "mbf21"
#define MBF22 "mbf22"
#define SIDE "side"
#define SIDELEADER "sideleader"
#define STAGE "stage"

Define("CoreVolunteer", [STAGE, SIDE])
Define("Leader", [LEADER, SIDELEADER])
Define("SideVolunteer", [SIDE, SIDELEADER])
Define("StageVolunteer", [LEADER, SIDE, SIDELEADER, STAGE])

# Jobs and roles
#define DATAENTRY "staff-dataentry"
#define JUDGE "judge"
#define RUNNER "runner"
#define SCRAMBLER "scrambler"
#define STAFFDELEGATE "staff-delegate"
#define STAFFJUDGE "staff-judge"
#define TABLEMANAGER "TableManager"