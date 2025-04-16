using AndradeR_LigaPro_Clase03.Models;

namespace AndradeR_LigaPro_Clase03.Interfaces
{
    public interface IEquipoRespository
    {
        List<Equipo> DevuelevListadoEquipos();
        Equipo DevuelveInfoEquipo();
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
    }
}
