# def check_hari(bulan: str):
#     bulan = bulan.lower()  # Mengubah input menjadi huruf kecil agar case-insensitive

#     if bulan == "januari":
#         hari = 31
#     elif bulan == "februari":
#         hari = 28  # Februari umumnya memiliki 28 hari (tidak memperhitungkan tahun kabisat)
#     elif bulan == "maret":
#         hari = 31
#     elif bulan == "april":
#         hari = 30
#     elif bulan == "mei":
#         hari = 31
#     elif bulan == "juni":
#         hari = 30
#     elif bulan == "juli":
#         hari = 31
#     elif bulan == "agustus":
#         hari = 31
#     elif bulan == "september":
#         hari = 30
#     elif bulan == "oktober":
#         hari = 31
#     elif bulan == "november":
#         hari = 30
#     elif bulan == "desember":
#         hari = 31
#     else:
#         return "Bulan tidak valid"

#     return f"{bulan.capitalize()} memiliki {hari} hari."

# # Contoh penggunaan
# bulan_input = input("Masukkan nama bulan: ")
# print(check_hari(bulan_input))


def check_hari(bulan: str):
    # Data jumlah hari dalam bulan menggunakan tuple
    days_in_month = {
        "januari": 31, "februari": 28, "maret": 31, "april": 30,
        "mei": 31, "juni": 30, "juli": 31, "agustus": 31,
        "september": 30, "oktober": 31, "november": 30, "desember": 31
    }

    bulan = bulan.lower()  # Mengubah input menjadi huruf kecil agar case-insensitive
    hari = days_in_month.get(bulan)  # Mengambil jumlah hari dari dictionary

    if hari:
        return f"{bulan.capitalize()} memiliki {hari} hari."
    else:
        return "Bulan tidak valid"

# Contoh penggunaan
bulan_input = input("Masukkan nama bulan: ")
print(check_hari(bulan_input))
