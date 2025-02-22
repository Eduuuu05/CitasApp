using CitasApp.Domain.Base;

namespace ClassApp.Domain.Entities.Usuarios
{
    public class Permiso : AuditEntity
    {
        public required string Nombre { get; set; }
    }
}