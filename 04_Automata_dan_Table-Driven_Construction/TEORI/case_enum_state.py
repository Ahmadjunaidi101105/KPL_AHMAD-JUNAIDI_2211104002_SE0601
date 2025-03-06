from enum import Enum

class Jeniskelamin(Enum):
    PRIA = 1
    WANITA = 2

patients = []

def add_patient(name: str, gender):
    if not isinstance(gender, Jeniskelamin):
        print(f"Error: Jeniskelamin untuk {name} harus PRIA atau WANITA")
      

    patients.append({"name": name, "gender": gender.name})
    print(f"Berhasil menambahkan pasien {name} dengan jenis kelamin {gender.name}")

# Contoh penggunaan
add_patient("Dandi", Jeniskelamin.PRIA)
add_patient("Siti", Jeniskelamin.WANITA)
  

