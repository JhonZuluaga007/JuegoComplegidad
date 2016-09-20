using Canon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Linq;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;
using System.Web.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Canon.Controllers
{
    public class FacebookController : Controller
    {

        public ActionResult getFacebook(string tocken, string id)
        {

            string url = "https://graph.facebook.com/debug_token?input_token=" + tocken + "" + "&access_token=1274845415868069|42659de328803bae76fa53e91d718c86";

            var client = new WebClient();
            JObject jObject = JObject.Parse(client.DownloadString(url));
            bool codigo = (bool)jObject["data"]["is_valid"];
            if (codigo == true)
            {
                return Content("correcto");
            }
            else
            {
                return Content("error");
            }
        }
    }
}
