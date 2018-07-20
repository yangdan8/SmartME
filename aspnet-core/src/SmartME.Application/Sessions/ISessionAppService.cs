using System.Threading.Tasks;
using Abp.Application.Services;
using SmartME.Sessions.Dto;

namespace SmartME.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
