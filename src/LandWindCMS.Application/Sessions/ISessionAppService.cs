using System.Threading.Tasks;
using Abp.Application.Services;
using LandWindCMS.Sessions.Dto;

namespace LandWindCMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
