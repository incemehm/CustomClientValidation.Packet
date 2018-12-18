using System;
using System.Web;
using System.Web.Routing;

namespace CustomClientValidation.Api
{
    public class RouteHandler : IRouteHandler
    {
        private IScriptGenerator _scriptGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHandler" /> class.
        /// </summary>
        /// <param name="proxyGenerator">The proxy generator.</param>
        public RouteHandler(IScriptGenerator scriptGenerator)
        {
            if (scriptGenerator == null) throw new ArgumentNullException("scriptGenerator");

            _scriptGenerator = scriptGenerator;
        }

        /// <summary>
        /// Provides the object that processes the request.
        /// </summary>
        /// <param name="requestContext">An object that encapsulates information about the request.</param>
        /// <returns>
        /// An object that processes the request.
        /// </returns>
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            if (requestContext == null) throw new ArgumentNullException("requestcontext");

            return new ScriptHttpHandler(_scriptGenerator);
        }
    }
}
