using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Unity.Benchmarks
{
    public partial class PipelineBenchmarks
    {
        protected ContainerAdapter Container;

        [Params("v4", "v5", "v6", "v8")]
        public string Unity;

        [IterationSetup]
        public void IterationSetup()
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
