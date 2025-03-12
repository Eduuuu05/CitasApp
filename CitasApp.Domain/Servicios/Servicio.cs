
using CitasApp.Domain.Citas;
using Microsoft.EntityFrameworkCore;

namespace CitasApp.Domain.Servicios
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
}

