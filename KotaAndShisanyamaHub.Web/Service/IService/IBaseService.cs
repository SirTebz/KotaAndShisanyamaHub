using KotaAndShisanyamaHub.Web.Models;

namespace KotaAndShisanyamaHub.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
