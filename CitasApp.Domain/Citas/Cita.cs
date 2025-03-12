
using CitasApp.Domain.Entities.Usuarios;
using CitasApp.Domain.Servicios;

namespace CitasApp.Domain.Citas
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int ServiceId { get; set; }
        public Servicio Servicio { get; set; } // Propiedad pública
    }
}

