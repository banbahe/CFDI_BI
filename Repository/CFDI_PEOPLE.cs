namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CFDI_PEOPLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CFDI_PEOPLE()
        {
            CFDI_ADDRESS = new HashSet<CFDI_ADDRESS>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RFC { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public int Tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFDI_ADDRESS> CFDI_ADDRESS { get; set; }
    }
}
