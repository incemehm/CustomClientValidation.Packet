using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Diagnostics.CodeAnalysis;


[assembly: PreApplicationStartMethod(typeof(CustomClientValidation.Api.ApiBootstrapper), "RegisterCustomRoutes")]
namespace CustomClientValidation.Api
{
    /// <summary>
	/// Bootstrapper that starts up the proxy generator.
	/// </summary>
	[ExcludeFromCodeCoverage]
    public static class ApiBootstrapper
    {
        /// <summary>
        /// Sets up the proxy route table entries.
        /// </summary>
        public static void RegisterCustomRoutes()
        {
            var routeValues = new RouteValueDictionary();
            routeValues.Add("controller", null);
            routeValues.Add("action", null);

            RouteTable.Routes.Add("ClientValidationApi",
                new Route("api/validations", routeValues, DependencyResolver.Instance.GetService<RouteHandler>()));

            //GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            //    name: "ApiClientValidation",
            //    routeTemplate: "api/{clientvalidation}/{controller}/{action}",
            //    defaults: new { },
            //    constraints: new { clientvalidation = "^clientvalidation$" }
            //);
        }
    }
}
