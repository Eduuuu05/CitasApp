
using CitasApp.Domain.Base;

namespace CitasApp.Domain.Entities.Usuarios
{
    public class Rol : AuditEntity
    {
        public required string Nombre { get; set; }
        public required ICollection<Usuario> Usuarios { get; set; }
    }

}