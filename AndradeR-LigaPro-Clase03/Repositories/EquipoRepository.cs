using AndradeR_LigaPro_Clase03.Models;

namespace AndradeR_LigaPro_Clase03.Repositories
{
    public class EquipoRepository
    {
        private static List<Equipo> Equipos; // Cambiamos a static para mantener los datos en memoria

        public EquipoRepository()
        {
            if (Equipos == null) // Solo inicializamos la lista si es null
            {
                Equipos = new List<Equipo>
                {
                    new Equipo { Id = 1, Nombre = "Mushuc Runa", PartidosJugados = 10, PartidosGanados = 0, PartidosPerdidos = 9, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/mushucruna-logo.png", Descripcion = "Fundado en 2003, representa con orgullo a las comunidades indígenas del país." },
                    new Equipo { Id = 2, Nombre = "Libertad FC", PartidosJugados = 10, PartidosGanados = 2, PartidosPerdidos = 7, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/libertad-logo.png", Descripcion = "Equipo de Loja fundado en 2017, joven pero con grandes aspiraciones en la Serie A." },
                    new Equipo { Id = 3, Nombre = "Aucas", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 6, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/aucas-logo.png", Descripcion = "Desde 1945 en Quito, 'Papá Aucas' es un símbolo de historia y pasión." },
                    new Equipo { Id = 4, Nombre = "Vinotinto Ecuador", PartidosJugados = 10, PartidosGanados = 3, PartidosPerdidos = 5, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/vinotinto-logo.png", Descripcion = "Una escuadra emergente de la capital, con ambiciones de hacerse un nombre en la élite." },
                    new Equipo { Id = 5, Nombre = "Orense", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 4, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/orense-logo.png", Descripcion = "El Auriverde de Machala, fundado en 2009, se mantiene firme en el torneo." },
                    new Equipo { Id = 6, Nombre = "Macará", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 3, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/macara-logo.png", Descripcion = "Desde 1939 en Ambato, 'El Celeste' es tradición y entrega." },
                    new Equipo { Id = 7, Nombre = "Técnico Universitario", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 4, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/tecnicouniversitario-logo.png", Descripcion = "Conocido como 'El Rodillo Rojo', representa la garra ambateña desde 1971." },
                    new Equipo { Id = 8, Nombre = "Manta FC", PartidosJugados = 10, PartidosGanados = 4, PartidosPerdidos = 3, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/manta-logo.png", Descripcion = "Club manabita apodado 'Los Atuneros', competitivo desde 1998." },
                    new Equipo { Id = 9, Nombre = "Delfín", PartidosJugados = 10, PartidosGanados = 5, PartidosPerdidos = 3, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/delfin-logo.png", Descripcion = "Equipo de Manta que alzó su primer título nacional en 2019." },
                    new Equipo { Id = 10, Nombre = "El Nacional", PartidosJugados = 10, PartidosGanados = 5, PartidosPerdidos = 3, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/nacional-logo.png", Descripcion = "Histórico club de Quito, reconocido por alinear exclusivamente jugadores ecuatorianos." },
                    new Equipo { Id = 11, Nombre = "Universidad Católica", PartidosJugados = 10, PartidosGanados = 5, PartidosPerdidos = 2, PartidosEmpatados = 3, LogoPath = "/imgs/logos-equipos/universidadcatolica-logo.png", Descripcion = "El Trencito Azul capitalino, regular animador del campeonato nacional." },
                    new Equipo { Id = 12, Nombre = "Deportivo Cuenca", PartidosJugados = 10, PartidosGanados = 6, PartidosPerdidos = 3, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/deportivocuenca-logo.png", Descripcion = "Representante de la ciudad de Cuenca, campeón nacional en 2004." },
                    new Equipo { Id = 13, Nombre = "Emelec", PartidosJugados = 10, PartidosGanados = 6, PartidosPerdidos = 2, PartidosEmpatados = 2, LogoPath = "/imgs/logos-equipos/emelec-logo.png", Descripcion = "Ídolo eléctrico de Guayaquil, protagonista constante del fútbol nacional." },
                    new Equipo { Id = 14, Nombre = "LDU Quito", PartidosJugados = 10, PartidosGanados = 7, PartidosPerdidos = 2, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/ligadequito-logo.png", Descripcion = "Reconocido internacionalmente como 'La U', con múltiples títulos nacionales e internacionales." },
                    new Equipo { Id = 15, Nombre = "Independiente del Valle", PartidosJugados = 10, PartidosGanados = 7, PartidosPerdidos = 2, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/independientedelvalle-logo.png", Descripcion = "Club modelo en formación juvenil y éxitos continentales, originario de Sangolquí." },
                    new Equipo { Id = 16, Nombre = "Barcelona SC", PartidosJugados = 10, PartidosGanados = 8, PartidosPerdidos = 1, PartidosEmpatados = 1, LogoPath = "/imgs/logos-equipos/barcelona-logo.png", Descripcion = "Fundado en 1925 en Guayaquil, es el club con más hinchas y uno de los más laureados de Ecuador." }
                };
            }
        }

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
        }

        public Equipo DevuelveEquipoPorId(int id)
        {
            return Equipos.FirstOrDefault(e => e.Id == id);
        }

        public bool ActualizarEquipo(int id, Equipo equipoActualizado)
        {
            var equipo = Equipos.FirstOrDefault(e => e.Id == id);
            if (equipo != null)
            {
                equipo.PartidosJugados = equipoActualizado.PartidosJugados;
                equipo.PartidosGanados = equipoActualizado.PartidosGanados;
                equipo.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
                equipo.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
                return true;
            }
            return false;
        }
    }

}

