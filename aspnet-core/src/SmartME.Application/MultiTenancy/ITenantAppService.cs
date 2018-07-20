using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartME.MultiTenancy.Dto;

namespace SmartME.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
