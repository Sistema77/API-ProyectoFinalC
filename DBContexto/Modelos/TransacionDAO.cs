using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ProyectoFinal_C.Modelo
{

    public class TransacionDAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdTransaccion { get; set; }
        public DateTime? FechaHora { get; set; }
        public decimal? CantidadDinero { get; set; }

        public int? IdCuentaEnvia { get; set; }

        // Relación N:1 con Cuenta (envía)
        [ForeignKey("IdCuentaEnvia")]
        public CuentaDAO? CuentaEnvia { get; set; }

        // Clave externa para la relación N:1 con Cuenta (recibe)
        public int? IdCuentaRecibe { get; set; }

        // Relación N:1 con Cuenta (recibe)
        [ForeignKey("IdCuentaRecibe")]
        public virtual CuentaDAO? CuentaRecibe { get; set; }

    }
}
