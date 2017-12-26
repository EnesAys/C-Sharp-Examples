using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace DenemeWebApi_withSql
{
    //public class CustomJsonFormatter : JsonMediaTypeFormatter
    //{
    //    public CustomJsonFormatter()
    //    {
    //        this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
    //    }
    //    public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
    //    {
    //        base.SetDefaultContentHeaders(type, headers, mediaType);
    //        headers.ContentType = new MediaTypeHeaderValue("application/json");
    //    }
    //}
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



            //config.Formatters.Add(new CustomJsonFormatter());//Yukarıda ki custom sınıfa giderek xml yerine Json dönmesini sağlar 
            //config.Formatters.Remove(config.Formatters.XmlFormatter);//Yalnızca Json döner.
            //config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;//Raw kısmında Json düzgün gözükür
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();//Raw kısmında Json düzgün gözükür
        }
    }
}
