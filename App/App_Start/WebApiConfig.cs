using App.LoggingMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace App
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            //config.Formatters.XmlFormatter.UseXmlSerializer = false;

            config.EnableCors(new System.Web.Http.Cors.EnableCorsAttribute("*", "*", "*"));

            config.MessageHandlers.Add(new RequestLoggingHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional}
            );
        }
    }
}
