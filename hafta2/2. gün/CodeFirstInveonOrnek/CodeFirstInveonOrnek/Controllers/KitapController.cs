using CodeFirstInveonOrnek.Data;
using CodeFirstInveonOrnek.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstInveonOrnek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        ApplicationDbContext _context;

        public KitapController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
       public async Task<ActionResult<IEnumerable<Kitap>>> KitaplariGetir()
        {
            //SQlConnection conn SqlCommand cmdText "select * from Kitap"
             List<Kitap> kitapListesi;
             kitapListesi =  await _context.Kitap.ToListAsync();

            //Kitap k1 = new Kitap();
            //Kitap k2 = new Kitap();
            //kitapListesi.Add(k1);
            //kitapListesi.Add(k1);

            //_context.Kitap.Select(k =>  new Kitap() )

     
            return kitapListesi;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Kitap>>>KitapEkle(Kitap kitap)
        {
            try
            {
                _context.Kitap.Add(kitap); //insert into Kitap(KitapAdi) values(kitap.kitapAdi);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }
            return Ok();//
        }
        //https://localhost:7273/api/kitap/3
        [HttpGet("{id}")]
         public async Task<ActionResult<Kitap>>KitapDetayGetir(int id)
        {
            //select * from Kitap where id=id
            var kitap = await _context.Kitap.FindAsync(id);
            if(kitap == null)
            {
                return NotFound();
            }
            return kitap;
        }

        [HttpPut]
        public async Task<ActionResult<IEnumerable<Kitap>>>KitapGuncelle(Kitap kitap)
        {
           _context.Entry(kitap).State =  EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }
            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Kitap>> KitapSil(int id)
        {
            Kitap silinecekKitap = await _context.Kitap.FindAsync(id);
            _context.Kitap.Remove(silinecekKitap);  //Delete from Kitap where id=id
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
