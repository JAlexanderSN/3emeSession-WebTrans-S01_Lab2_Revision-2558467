using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MaListe = new List<Zombie>()
            {
                new Zombie(){m_Name= "LeChuck", m_Point=5, m_Type="Fiction",},
                new Zombie(){m_Name= "Lenore", m_Point=4, m_Type="Fiction",},
                new Zombie(){m_Name= "Draugr", m_Point=2, m_Type="Légendaire",},
                new Zombie(){m_Name= "Ragamuffin", m_Point=5, m_Type="Légendaire",},
                new Zombie(){m_Name= "Taxidermy", m_Point=1, m_Type="Légendaire",},
                new Zombie(){m_Name= "chien de l'enfer", m_Point=7, m_Type="Fiction",},
                new Zombie(){m_Name= "Avogadro", m_Point=9, m_Type="Fiction",}
            };

            return View();

        }
    }
}
