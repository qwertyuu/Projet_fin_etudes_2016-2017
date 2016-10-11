using System.Threading.Tasks;
using Abp.Application.Services;
using ECJ.Roles.Dto;

namespace ECJ.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
