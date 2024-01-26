using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ProyectoFinal_C.Modelo
{

    public class CreditoDAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_Credito")]
        public int? IdCredito { get; set; }
        public decimal? CantidadPrestamo { get; set; }
        public decimal? CuotaMensual { get; set; }
        public string? EstadoPrestamo { get; set; }
        public DateTime? FechaFinal { get; set; }
        public DateTime? FechaInicio { get; set; }
        public decimal? TasaInteres { get; set; }
        public string? TipoPrestamo { get; set; }

        // Relación N:1 con Cuenta

        public int? IdCuenta { get; set; }

        [ForeignKey("id_cuenta")]
        public virtual CuentaDAO? Cuenta { get; set; }


        public CreditoDAO()
        {
        }
    }
}
