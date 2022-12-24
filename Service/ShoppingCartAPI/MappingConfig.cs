using AutoMapper;
using ShoppingCartAPI.Models;
using ShoppingCartAPI.Models.Dtos;

namespace ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<CartHeader,CartHeaderDto>();
                config.CreateMap<CartDetails,CartDetailsDto>();
                config.CreateMap<Cart,CartDto>();
            });

            return mappingConfig;
        }
    }
}
