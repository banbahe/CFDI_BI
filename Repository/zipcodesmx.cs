namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zipcodesmx")]
    public partial class zipcodesmx
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string codigo { get; set; }

        [Required]
        [StringLength(250)]
        public string asentamiento { get; set; }

        [StringLength(250)]
        public string tipo_asentamiento { get; set; }

        [StringLength(250)]
        public string municipio { get; set; }

        [StringLength(250)]
        public string estado { get; set; }

        [StringLength(250)]
        public string ciudad { get; set; }

        [StringLength(250)]
        public string x1 { get; set; }

        [StringLength(250)]
        public string y1 { get; set; }

        [StringLength(250)]
        public string x2 { get; set; }

        [StringLength(250)]
        public string y2 { get; set; }
    }
}
