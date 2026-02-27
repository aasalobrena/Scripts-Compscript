import requests
import qrcode
import csv
import os
from pathlib import Path

assignment_letter = {
    "competitor": "C",
    "staff-judge": "J",
    "staff-runner": "R",
    "staff-scrambler": "S",
    "staff-delegate": "D"
}

def generate_qr(link, output_path):
    qr = qrcode.QRCode(
        version=None,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=3,
        border=1,
    )
    qr.add_data(link)
    qr.make(fit=True)
    img = qr.make_image(fill_color="white", back_color="black").convert("RGBA")
    qr_data = img.getdata()
    qr_new_data = []

    for item in qr_data:
        if item[:3] == (0, 0, 0):
            qr_new_data.append((0, 0, 0, 0))
        else:
            qr_new_data.append(item)

    img.putdata(qr_new_data)
    img.save(output_path)

competition_id = "CampeonatodeAndalucia2026"
wcif_url = f"https://www.worldcubeassociation.org/api/v0/competitions/{competition_id}/wcif/public"
output_dir = "qrs"
os.makedirs(output_dir, exist_ok=True)

link = f"https://live.worldcubeassociation.org/link/competitions/{competition_id}/"
path = os.path.join(output_dir, "live.png")
generate_qr(link, path)

link = f"https://www.competitiongroups.com/competitions/{competition_id}"
path = os.path.join(output_dir, "groups.png")
generate_qr(link, path)

try:
    response = requests.get(wcif_url)
    response.raise_for_status()
    wcif = response.json()
    data = [["id", "name", "wcaId", "qr"]]

    groups = [
        child
        for activity in wcif["schedule"]["venues"][0]["rooms"][0]["activities"]
        if activity["activityCode"].endswith("r1")
        for child in activity.get("childActivities", [])
    ]

    for group in groups:
        data[0].append(f"c-{group["activityCode"]}")
        data[0].append(f"a-{group["activityCode"]}")

    for person in wcif["persons"]:
        if person["registrantId"] is not None:
            link = f"https://www.competitiongroups.com/competitions/{competition_id}/persons/{person["registrantId"]}"
            path = os.path.join(output_dir, f"{person["registrantId"]}.png")
            generate_qr(link, path)

            row = [f"ID: {person["registrantId"]}", f"{person["name"]}"]

            if person["wcaId"] is not None:
                row.append(person["wcaId"])
            else:
                row.append("NUEVA COMPETIDORA" if person["gender"] == "f" else "NUEVO COMPETIDOR")

            row.append(Path.cwd() / path)
            assignments = person["assignments"]

            for group in groups:
                found = False
                for assignment in assignments:
                    if group["id"] == assignment["activityId"]:
                        extension = next(
                            (
                                ext
                                for ext in group.get("extensions", [])
                                if ext.get("id") == "org.cubingusa.natshelper.v1.Group"
                            ),
                            None
                        )
                        if extension:
                            stage_id = extension["data"]["stageId"]
                            image_path = Path.cwd() / f"{stage_id}.png"
                            letter = assignment_letter[assignment["assignmentCode"]]
                            row.extend([image_path, letter])
                        else:
                            row.extend(["", ""])
                        found = True
                        break
                if not found:
                    row.extend(["", ""])

            data.append(row)

    with open("badges.csv", mode="w", newline="", encoding="utf-8-sig") as file:
        writer = csv.writer(file, delimiter=";")
        writer.writerows(data)

except Exception as e:
    print(f'Error: {e}')



