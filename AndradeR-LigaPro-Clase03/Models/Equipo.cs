using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AndradeR_LigaPro_Clase03.Models
{
    public class Equipo
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre Equipo: ")]
        [Required]
        //public string? Nombre { get; set; } : "?" Significa que puede ser nulo        
        public string Nombre { get; set; }
        [Range(0, 20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int Puntos
        {
            get
            {
                int puntos = PartidosGanados * 3 + PartidosEmpatados * 1;
                return puntos;
            }
        }
    }
}
