namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CFDI_ADDRESS
    {
        public int Id { get; set; }

        [StringLength(450)]
        public string calle { get; set; }

        [StringLength(450)]
        public string colonia { get; set; }

        [StringLength(450)]
        public string municipio { get; set; }

        [StringLength(450)]
        public string estado { get; set; }

        [StringLength(450)]
        public string pais { get; set; }

        [StringLength(450)]
        public string codigoPostal { get; set; }

        [StringLength(450)]
        public string noExterior { get; set; }

        public int Id_CFDI_PEOPLE { get; set; }

        public virtual CFDI_PEOPLE CFDI_PEOPLE { get; set; }
    }
}
