using Microsoft.AspNetCore.Mvc;
using modul9_2211104002;
using tpmodul9_2211104002;

namespace tpmodul9_2211104026.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Ahmad Junaidi", Nim = "2211104002" },
            new Mahasiswa { Nama = "Kholiahdina", Nim = "2211104006" },
            new Mahasiswa { Nama = "Nita fitrotul", Nim = "2211104023" },
            new Mahasiswa { Nama = "Alfian Mutakim", Nim = "2211104011" }
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return daftarMahasiswa;
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            return daftarMahasiswa[index];
        }

        // POST /api/mahasiswa
        [HttpPost]
        public ActionResult AddMahasiswa(Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok();
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
