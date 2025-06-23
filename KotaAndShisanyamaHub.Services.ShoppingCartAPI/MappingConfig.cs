using AutoMapper;
using KotaAndShisanyamaHub.Services.ShoppingCartAPI.Models;
using KotaAndShisanyamaHub.Services.ShoppingCartAPI.Models.Dto;

namespace KotaAndShisanyamaHub.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
