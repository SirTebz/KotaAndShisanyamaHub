using KotaAndShisanyamaHub.Services.ShoppingCartAPI.Models.Dto;

namespace KotaAndShisanyamaHub.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
