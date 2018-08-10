using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi_JqueryAjax_Json_Get.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //apiyi dışarı açtık. Bunun için nugetten Microsoft.AspNet.WebApi.Cors yükledik.
            var corsAttr = new EnableCorsAttribute("http://localhost:13592", "*", "*");
            config.EnableCors(corsAttr);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //veriler json dönmesi için.
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
