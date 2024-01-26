using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ProyectoFinal_C.Modelo { 

    public class CuentaDAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_cuenta")]
        public int? IdCuenta { get; set; }
        public string? ConNomina { get; set; }
        public DateTime? FechaApertura { get; set; }
        public string? NumeroCuenta { get; set; }
        public decimal? Saldo { get; set; }

        // Relación 1:N con Transacciones
        public ICollection<TransacionDAO>? TransacionesEnviadas { get; set; }
        public ICollection<TransacionDAO>? TransacionesRecibidas { get; set; }

        // Relación 1:N con Credito
        public ICollection<CreditoDAO>? Creditos { get; set; }

        // Relación N:1 con Usuario
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual UsuarioDAO? Usuario { get; set; }

        public CuentaDAO()
        {
            //Construcion en HashSet para evitar Execpciones 
            TransacionesEnviadas = new HashSet<TransacionDAO>();
            TransacionesRecibidas = new HashSet<TransacionDAO>();
            Creditos = new HashSet<CreditoDAO>();
        }
    }
}
