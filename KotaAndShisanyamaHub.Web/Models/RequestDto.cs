using System.Net.Mime;
using System.Security.AccessControl;
using static KotaAndShisanyamaHub.Web.Utility.SD;

namespace KotaAndShisanyamaHub.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }

    }
}
