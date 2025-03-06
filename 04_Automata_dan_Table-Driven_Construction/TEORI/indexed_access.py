def get_days_in_month(bulan: str) -> int:
    months = ["januari", "februari", "maret", "april", "mei", "juni",
              "juli", "agustus", "september", "oktober", "november", "desember"]
    
    days_in_month = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]

    # Pastikan input dalam format lowercase agar tidak error
    bulan = bulan.lower()

    # Periksa apakah bulan ada dalam daftar months
    if bulan in months:
        index = months.index(bulan)  # Cari indeks bulan dalam daftar
        return days_in_month[index]  # Ambil jumlah hari berdasarkan indeks
    else:
        return "Bulan tidak valid"

# Contoh penggunaan
bulan_input = input("Masukkan nama bulan: ")
jumlah_hari = get_days_in_month(bulan_input)
print(f"Jumlah hari dalam bulan {bulan_input.capitalize()} adalah {jumlah_hari} hari.")
