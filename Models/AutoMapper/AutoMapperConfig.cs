using AutoMapper;
using AutoMapper.EquivalencyExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.AutoMapper
{
    public class AutoMapperConfig
    {
        public AutoMapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddCollectionMappers();
            });
        }
    }
}
