using AndradeR_LigaPro_Clase03.Models;
using AndradeR_LigaPro_Clase03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AndradeR_LigaPro_Clase03.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();

            return View(equipos);
        }

        public IActionResult Edit(int ID)
        {
            Equipo ldu = new Equipo
            {
                ID = 1,
                Nombre = "Ldu",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            return View(ldu);
        }
    }
}
