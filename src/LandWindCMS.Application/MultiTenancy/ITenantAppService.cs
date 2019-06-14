using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LandWindCMS.MultiTenancy.Dto;

namespace LandWindCMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

