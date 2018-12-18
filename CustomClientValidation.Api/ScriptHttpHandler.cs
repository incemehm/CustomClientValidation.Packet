﻿using System;
using System.Web;

namespace CustomClientValidation.Api
{
    public class ScriptHttpHandler : IHttpHandler
    {
        private static string _script;
        private static volatile object _syncRoot = new object();
        private IScriptGenerator _generator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptHttpHandler" /> class.
        /// </summary>
        /// <param name="generator">The generator.</param>
        public ScriptHttpHandler(IScriptGenerator generator)
        {
            if (generator == null) throw new ArgumentNullException("generator");

            _generator = generator;
        }

        /// <summary>
        /// Gets a value indicating whether another request can use the <see cref="T:System.Web.IHttpHandler" /> instance.
        /// </summary>
        /// <returns>true if the <see cref="T:System.Web.IHttpHandler" /> instance is reusable; otherwise, false.</returns>
        public bool IsReusable
        {
            get { return true; }
        }

        /// <summary>
        /// Enables processing of HTTP Web requests by a custom HttpHandler that implements the <see cref="T:System.Web.IHttpHandler" /> interface.
        /// </summary>
        /// <param name="context">An <see cref="T:System.Web.HttpContext" /> object that provides references to the intrinsic server objects (for example, Request, Response, Session, and Server) used to service HTTP requests.</param>
        public void ProcessRequest(HttpContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            context.Response.ContentType = "application/x-javascript";
            context.Response.Write(GetProxyJs(context));
        }

        private string GetProxyJs(HttpContext context)
        {
            if (_script == null)
                lock (_syncRoot)
                    if (_script == null)
                    {
                        _script = _generator.GenerateScript(); 
                    }

            return _script;
        }
    }
}
