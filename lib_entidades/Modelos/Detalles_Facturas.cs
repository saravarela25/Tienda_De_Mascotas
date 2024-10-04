using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    using System;
    using System.Collections.Generic;

    public partial class Detalles_Facturas
    {
        [Key] public int Id { get; set; }
        public DateTime? Fecha_Servicio { get; set; }
        public string? Estado { get; set; }
        public decimal IVA { get; set; }
        public decimal Precio_Venta { get; set; }

        [ForeignKey("Factura")] public int Factura { get; set; }
        [ForeignKey("Mascota")] public int Mascota { get; set; }
        [ForeignKey("Servicio")] public int Servicio { get; set; }


        [NotMapped] public virtual Facturas? _Factura { get; set; }
        [NotMapped] public virtual Mascotas? _Mascota { get; set; }
        [NotMapped] public virtual Servicios? _Servicio { get; set; }
    }
}
