using KotaAndShisanyamaHub.Services.ShoppingCartAPI.Models.Dto;

namespace KotaAndShisanyamaHub.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
