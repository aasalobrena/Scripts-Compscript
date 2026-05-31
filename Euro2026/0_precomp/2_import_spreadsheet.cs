#include "../lib/_constants.cs"

ReadSpreadsheet("1LPQwQmWBlp6IrJej-Xq7_6egJu69Z2G2TJduf6gNHKc", sheetTitle="compscript")

AddRole(Persons((StringProperty(TEAM) == DATA)), DATAENTRY)