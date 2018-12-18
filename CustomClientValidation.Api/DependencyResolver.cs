using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CustomClientValidation.Api
{
    public class DependencyResolver : IDependencyResolver
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyResolver" /> class.
        /// </summary>
        public DependencyResolver()
        { }

        #endregion

        #region IDependencyResolver Members

        /// <summary>
        /// Resolves singly registered services that support arbitrary object creation.
        /// </summary>
        /// <param name="serviceType">The type of the requested service or object.</param>
        /// <returns>
        /// The requested service or object.
        /// </returns>
        public object GetService(Type serviceType)
        {
            if (typeof(IScriptGenerator) == serviceType)
                return new ScriptGenerator();

            if (typeof(RouteHandler) == serviceType)
                return new RouteHandler(GetService<IScriptGenerator>());

            return null;
        }

        private TService GetService<TService>()
        {
            return (TService)this.GetService(typeof(TService));
        }

        /// <summary>
        /// Resolves multiply registered services.
        /// </summary>
        /// <param name="serviceType">The type of the requested services.</param>
        /// <returns>
        /// The requested services.
        /// </returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            yield return GetService(serviceType); ;
        }

        #endregion

        #region Singleton Implementation

        private static readonly DependencyResolver _instance = new DependencyResolver();

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static IDependencyResolver Instance
        {
            get { return _instance; }
        }

        #endregion
    }
}
