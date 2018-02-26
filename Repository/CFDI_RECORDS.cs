namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CFDI_RECORDS
    {
        public int Id { get; set; }

        public string version { get; set; }

        public string serie { get; set; }

        public string folio { get; set; }

        public DateTime? fecha { get; set; }

        public string formaDePago { get; set; }

        public decimal? subtotal { get; set; }

        public decimal? TipoCambio { get; set; }

        public string Moneda { get; set; }

        public decimal? total { get; set; }

        public string tipoDeComprobante { get; set; }

        public string metodoDePago { get; set; }

        [Required]
        [StringLength(50)]
        public string UUID { get; set; }

        public int? Id_Emisor { get; set; }

        public int? Id_Receptor { get; set; }
    }
}
