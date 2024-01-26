using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ProyectoFinal_C.Modelo
{
    public class UsuarioDAO
    {
        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }
        public string? Dni { get; set; }
        public string? Email { get; set; }
        public string? Foto { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? TipoUsuario { get; set; }
        public bool? Flt { get; set; }

        // Relación 1:N con Cuenta
        public ICollection<CuentaDAO>? Cuentas { get; set; }

        public UsuarioDAO()
        {
            // Para Evitar errores cuando no hay Cuentas creadas 
            Cuentas = new HashSet<CuentaDAO>();
        }
    }

}
