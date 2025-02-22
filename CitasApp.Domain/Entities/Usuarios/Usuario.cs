using CitasApp.Domain.Base;

namespace CitasApp.Domain.Entities.Usuarios
{
    public class Usuario : AuditEntity
    {
        public required string Nombre { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required int RolId { get; set; } 
        public required Rol Rol { get; set; }  
    }
}