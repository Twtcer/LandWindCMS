using System.Threading.Tasks;
using Abp.Application.Services;
using LandWindCMS.Authorization.Accounts.Dto;

namespace LandWindCMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
