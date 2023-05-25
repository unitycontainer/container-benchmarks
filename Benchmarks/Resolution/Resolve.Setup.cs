using BenchmarkDotNet.Attributes;
using System;
using System.IO;
using System.Reflection;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks
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

        public interface IService { }

        public interface IService<T> { }

        public class Service : IService { }

        public class Service<T> : IService<T> { }

        public class TestGeneric<T> 
        {
            object _value;

            public TestGeneric(object value)
            {
                _value = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
    }
}
