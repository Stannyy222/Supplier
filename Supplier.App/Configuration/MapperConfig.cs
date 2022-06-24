using AutoMapper;
using Huerto___ENTPROG___OTIS1;
using Supplier.App.Models;

namespace Supplier.App.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<product, productVM>().ReverseMap();
        }
    }
}
