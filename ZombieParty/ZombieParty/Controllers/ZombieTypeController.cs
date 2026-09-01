using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MaListe = new List<ZombieType>()
            {
                    new ZombieType(){m_TypeName= "Virus", m_Id=1},
                    new ZombieType(){m_TypeName= "Contact", m_Id=2}
            };

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.ZombieType zombieType)
        {
            

            if (ModelState.IsValid)
            {

                // Pas reussi
               
            }

            return this.View(zombieType);
        }



    }
}
