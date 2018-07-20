using Microsoft.AspNetCore.Antiforgery;
using SmartME.Controllers;

namespace SmartME.Web.Host.Controllers
{
    public class AntiForgeryController : SmartMEControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
