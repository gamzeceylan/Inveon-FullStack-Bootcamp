using KitapMVCInveonOrnek.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using Newtonsoft.Json;

namespace KitapMVCInveonOrnek.Controllers
{
    public class KitapController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Kitap> kitapListesi = new List<Kitap>();
            using(var httpClient =  new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7273/api/Kitap"))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                   kitapListesi =  JsonConvert.DeserializeObject<List<Kitap>>(gelenString);
                }
            }
            return View(kitapListesi);
        }

        public async Task<IActionResult> KitapDetay(int id)
        {
            Kitap kitapDetay;

            using(var httpClient = new HttpClient())
            {
                using( var yanit = await httpClient.GetAsync("https://localhost:7273/api/Kitap/"+id))
                {
                    string gelenString = await yanit.Content.ReadAsStringAsync();
                    kitapDetay = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }


            return View(kitapDetay);
        }


        public 
    }
}
