using BasicApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OgrenciController : ControllerBase
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci { Id = 1, AdSoyad = "Rumeysa ALKAYA" },
            new Ogrenci { Id = 2, AdSoyad = "Ahmet ÖZGÜL" },
            new Ogrenci { Id = 3, AdSoyad = "Deneme ÖZGÜL" },
        };

        [HttpGet]
        public List<Ogrenci> Get()
        {

            return ogrenciler;
        }

        [HttpGet("{id}")]
        public Ogrenci Get(int id)
        {
            return ogrenciler.FirstOrDefault(o => o.Id == id);
        }

        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return ogrenci;
        }

    }
}
