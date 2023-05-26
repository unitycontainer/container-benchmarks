using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.IO;
using System.Reflection;

namespace Unity.Benchmarks
{
    public partial class RegistrationBenchmarks : BenchmarksBase
    {
        protected Service Instance = new Service();


        #region Type

        [Benchmark(Description = "RegisterType(type)")]
        [BenchmarkCategory("Register", "Type", "RegisterType", "IUnityContainer")]
        public object RegisterType() => Container.RegisterType(typeof(object));



        [Benchmark(Description = "RegisterType(type, name)")]
        [BenchmarkCategory("Register", "Type", "RegisterType", "IUnityContainer")]
        public object RegisterTypeNamed() => Container.RegisterType(typeof(object), "name");



        [Benchmark(Description = "RegisterType(IService, Service)")]
        [BenchmarkCategory("Register", "Type", "RegisterType", "IUnityContainer")]
        public object RegisterTypeMap() => Container.RegisterType(typeof(IService), typeof(Service));

        #endregion


        #region Instance

        [Benchmark(Description = "RegisterInstance(type, instance)")]
        [BenchmarkCategory("Register", "Instance", "RegisterInstance", "IUnityContainer")]
        public object RegisterInstance() => Container.RegisterInstance(typeof(Service), Instance);



        [Benchmark(Description = "RegisterInstance(type, name, instance)")]
        [BenchmarkCategory("Register", "Instance", "RegisterInstance", "IUnityContainer")]
        public object RegisterInstanceNamed() => Container.RegisterInstance(typeof(Service), "name", Instance);

        #endregion
    }
}
