
using CitasApp.Domain.Base;

namespace CitasApp.Domain.Entities.Usuarios
{
    public class Rol : AuditEntity
    {
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
