using Microsoft.AspNetCore.Antiforgery;
using LandWindCMS.Controllers;

namespace LandWindCMS.Web.Host.Controllers
{
    public class AntiForgeryController : LandWindCMSControllerBase
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
