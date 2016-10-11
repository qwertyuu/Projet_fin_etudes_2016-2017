using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ECJ.MultiTenancy.Dto;

namespace ECJ.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
