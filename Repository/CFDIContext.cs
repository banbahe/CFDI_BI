namespace Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CFDIContext : DbContext
    {
        public CFDIContext()
            : base("name=CFDIContext")
        {
        }

        public virtual DbSet<CFDI_ADDRESS> CFDI_ADDRESS { get; set; }
        public virtual DbSet<CFDI_PEOPLE> CFDI_PEOPLE { get; set; }
        public virtual DbSet<CFDI_RECORDS> CFDI_RECORDS { get; set; }
        public virtual DbSet<zipcodesmx> zipcodesmxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.municipio)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.codigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_ADDRESS>()
                .Property(e => e.noExterior)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_PEOPLE>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_PEOPLE>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_PEOPLE>()
                .HasMany(e => e.CFDI_ADDRESS)
                .WithRequired(e => e.CFDI_PEOPLE)
                .HasForeignKey(e => e.Id_CFDI_PEOPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.formaDePago)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.TipoCambio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.total)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.tipoDeComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.metodoDePago)
                .IsUnicode(false);

            modelBuilder.Entity<CFDI_RECORDS>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.asentamiento)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.tipo_asentamiento)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.municipio)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.x1)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.y1)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.x2)
                .IsUnicode(false);

            modelBuilder.Entity<zipcodesmx>()
                .Property(e => e.y2)
                .IsUnicode(false);
        }
    }
}
