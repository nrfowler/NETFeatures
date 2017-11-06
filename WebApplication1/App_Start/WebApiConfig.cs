﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
    using System.Web.Http;

namespace WebApplication1.App_Start
{

    class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling
= Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}