using AutoMapper;
using KotaAndShisanyamaHub.Services.CouponAPI.Models;
using KotaAndShisanyamaHub.Services.CouponAPI.Models.Dto;

namespace KotaAndShisanyamaHub.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
