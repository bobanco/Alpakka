﻿using Akka.Streams.SignalR.AspNetCore;
using Akka.Streams.SignalR.AspNetCore.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AkkaSignalRDependencyInjectionExtensions
    {
        /// <summary>
        /// Add SignalR Akka Stream connector
        /// </summary>
        /// <param name="services"></param>
        public static void AddSignalRAkkaStream(this IServiceCollection services)
            => services.Add(new ServiceDescriptor(typeof(IStreamDispatcher), 
                typeof(DefaultStreamDispatcher), ServiceLifetime.Singleton));
    }
}
