using AndradeR_LigaPro_Clase03.Interfaces;
using AndradeR_LigaPro_Clase03.Models;
using AspNetCoreGeneratedDocument;

namespace AndradeR_LigaPro_Clase03.Repositories
{

    public class EquipoRepository : IEquipoRespository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public List<Equipo> DevuelevListadoEquipos()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Equipo> DevuelveListadoEquipos()
        {

            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                ID = 1,
                Nombre = "Ldu",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                ID = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };
            equipos.Add(bsc);

            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}

