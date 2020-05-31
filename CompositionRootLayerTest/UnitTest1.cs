using System;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CompositionRootLayerTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestCompositionRootBuild()
        {
            var serviceCollection = new ServiceCollection();
            CompositionRootLayer.CompositionRootBuilder.Build(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var service = serviceCollection.GetEnumerator();
            while (service.MoveNext())
            {
                Assert.NotNull(serviceProvider.GetService(service.Current.ServiceType));
            }
        }
    }
}