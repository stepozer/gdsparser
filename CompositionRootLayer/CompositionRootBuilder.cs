using System;
using InfrastuctureLayer;
using InfrastuctureLayer.Gds.Sirena;
using Microsoft.Extensions.DependencyInjection;

namespace CompositionRootLayer
{
    public class CompositionRootBuilder
    {
        public static void Build(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<Logger>();
            serviceCollection.AddTransient<Client>();
            serviceCollection.AddTransient<Driver>();
        }
    }
}