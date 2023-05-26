using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.IO;
using System.Reflection;

namespace Unity.Benchmarks
{
    [Orderer(SummaryOrderPolicy.Method, MethodOrderPolicy.Declared)]
    public abstract class BenchmarksBase
    {
        protected ContainerAdapter Container;
        protected string Name = "name";


        [Params("v4", "v5", "v6", "v8")]
        public string Unity;

        [IterationSetup]
        public virtual void IterationSetup()
        {
            var path = Path.GetFullPath($"..\\..\\..\\..\\..\\Adapters\\Container.{Unity}",
                       Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            Directory.SetCurrentDirectory(path);

            var type = Assembly.LoadFrom($"Container.{Unity}.dll")
                               .GetType($"Unity.{Unity}.UnityAdapter");

            Container = (ContainerAdapter)Activator.CreateInstance(type);
        }
    }
}
