using ODataSelectTest.Models;
using ODataSelectTest.Services;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataSelectTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            DbManager.AddSampleData();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            builder.EntitySet<Person>("People");
            config.MapODataServiceRoute(
                routeName: "DefaultOData",
                routePrefix: "odata",
                model: builder.GetEdmModel());
        }
    }
}
