using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingconfig = new MapperConfiguration(Config => 
            {
                Config.CreateMap<ProductVO, Product>();
                Config.CreateMap<Product, ProductVO>();
            });
            return mappingconfig;
        }
    }
}
