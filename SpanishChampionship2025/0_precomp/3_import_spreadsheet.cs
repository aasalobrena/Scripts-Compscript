#include "../lib/_constants.cs"

ReadSpreadsheet("1Q0B1cHT3HRIuiiSK9qGc_-RSspd1jNZURfizRKShSYc", sheetTitle="compscript")

AddRole(Persons((StringProperty("team") == DATA_TEAM)), DATAENTRY)