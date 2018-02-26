using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Repository;
namespace CFDI.AutoMapper
{
    public class AutoMapperConfig
    {
        public AutoMapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddCollectionMappers();


                cfg.CreateMap<Models.CFDI, CFDI_RECORDS>()
                .ForMember(x => x.version, x => x.MapFrom(y => y.version))
                .ForMember(x => x.serie, x => x.MapFrom(y => y.serie))
                .ForMember(x => x.folio, x => x.MapFrom(y => y.folio))
                .ForMember(x => x.fecha, x => x.MapFrom(y => y.fecha))
                .ForMember(x => x.formaDePago, x => x.MapFrom(y => y.formaDePago))
                .ForMember(x => x.subtotal, x => x.MapFrom(y => y.subTotal))
                .ForMember(x => x.TipoCambio, x => x.MapFrom(y => y.TipoCambio))
                .ForMember(x => x.Moneda, x => x.MapFrom(y => y.Moneda))
                .ForMember(x => x.total, x => x.MapFrom(y => y.total))
                .ForMember(x => x.tipoDeComprobante, x => x.MapFrom(y => y.tipoDeComprobante))
                .ForMember(x => x.metodoDePago, x => x.MapFrom(y => y.metodoDePago))
                .ForMember(x => x.UUID, x => x.MapFrom(y => y.UUID));


                
                //cfg.CreateMap<Models.CFDI, CFDI_PEOPLE>()
                //.ForMember(x => x.Nombre , x => x.MapFrom(y => y.emisor.nombre))
                //.ForMember(x => x.RFC , x => x.MapFrom(y => y.emisor.rfc))
                //.ForMember(x => x.CFDI_ADDRESS , x => x.MapFrom(y => y.emisor.rfc));

                //cfg.CreateMap<Models.CFDI, CFDI_ADDRESS>()
                //.ForMember(x => x.calle, x => x.MapFrom(y => y.emisor.nombre))
                //.ForMember(x => x.RFC, x => x.MapFrom(y => y.emisor.rfc));
                
                //cfg.CreateMap<Models.Emisor, CFDI_PEOPLE>()
                //.ForMember(x => x.Nombre, x => x.MapFrom(y => y.nombre));

            });
        }
    }
}
