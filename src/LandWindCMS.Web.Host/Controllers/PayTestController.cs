using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using LandWindCMS.Controllers;
using Microsoft.AspNetCore.Mvc; 

namespace LandWindCMS.Web.Host.Controllers
{ 
    public class PayTestController : LandWindCMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public string NoityUrl(string dh, string ltype)
        {
            if (string.IsNullOrEmpty(dh) || string.IsNullOrEmpty(ltype))
            {
                return "error";
            }
            else
            {

                return "success";
            }
        }

        #region Model
        public   class PayConfig
        {
            public string GatewayUrl { get; set; } = "http://pay.edlm.cn/";
            public string AppId { get; set; } = "e5c0f80d4060a8db42b1394f9b966725";
            public string NoityUrlAsync { get; set; } = HttpUtility.UrlEncode( "");
            public string ReturnUrl { get; set; }
            public string Money { get; set; } 
        }
        #endregion
    }
}
