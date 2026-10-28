# Assignment Sets
#define TOP_SIDE_SET "top-side-"
#define SIDE_SET "side"
#define TOP_SET "top-"
#define CORE_SET "core"
#define DELEGATES_SET "delegates-"
#define AES_SET "aes"
#define DATA_SET "data"
#define STREAMING_SET "streaming"
#define EVERYONE_SET "everyone"

# Jobs
#define JUDGE "judge"
#define RUNNER "runner"
#define SCRAMBLER "scrambler"
#define DELEGATE "delegate"
Define("StandardJobs", [JUDGE, RUNNER, SCRAMBLER])

# Properties
#define WEIGHT_JUDGE "weight-judge"
#define WEIGHT_RUNNER "weight-runner"
#define WEIGHT_SCRAMBLER "weight-scrambler"
#define DELEGATE_CLUSTER "delegate-cluster"
#define PUZZLES "puzzles"

# Puzzles
#define INDIVIDUAL "individual"
#define PAREJAS "parejas"

# Roles
#define DATA_ROLE "staff-dataentry"

# Rooms
#define MAIN_ROOM "Pabellón"
#define SIDE_ROOM "Sala Auxiliar"

# Stages
#define ARABA_STAGE    "Araba"
#define BIZKAIA_STAGE  "Bizkaia"
#define GIPUZKOA_STAGE "Gipuzkoa"
Define("AllStages",        [ARABA_STAGE, BIZKAIA_STAGE, GIPUZKOA_STAGE])
Define("FinalsStages",     [BIZKAIA_STAGE, GIPUZKOA_STAGE])
Define("AllStagesRoom",    [ARABA_STAGE, BIZKAIA_STAGE, GIPUZKOA_STAGE, MAIN_ROOM])
Define("FinalsStagesRoom", [BIZKAIA_STAGE, GIPUZKOA_STAGE, MAIN_ROOM])

# Volunteer teams
#define TEAM "team"
#define CORE_TEAM "Organizador"
#define DELEGATE_TEAM "Delegado"
#define STAGE_TEAM "Voluntario normal"
#define SIDE_TEAM "Side room"
#define AES_TEAM "Registro / Stand AES"
#define DATA_TEAM "Data entry"
#define STREAMING_TEAM "Streaming"
#define ACCESS_TEAM "Control de Accesos"
#define DOCTOR_TEAM "Médico"
#define OTRO_TEAM "Otro"
Define("AllTeams", [CORE_TEAM, DELEGATE_TEAM,  STAGE_TEAM,  SIDE_TEAM,   AES_TEAM,
                    DATA_TEAM, STREAMING_TEAM, ACCESS_TEAM, DOCTOR_TEAM, OTRO_TEAM]
      )
