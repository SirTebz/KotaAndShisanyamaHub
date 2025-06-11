using AutoMapper;
using KotaAndShisanyamaHub.Services.ProductAPI.Models;
using KotaAndShisanyamaHub.Services.ProductAPI.Models.Dto;

namespace KotaAndShisanyamaHub.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
