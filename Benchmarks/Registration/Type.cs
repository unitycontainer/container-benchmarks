using BenchmarkDotNet.Attributes;


namespace Unity.Benchmarks
{
    public partial class RegistrationBenchmarks
    {
        [Benchmark(Description = "RegisterType(type)")]
        [BenchmarkCategory("Register", "Type", "RegisterType", "IUnityContainer")]
        public object RegisterType() => Container.RegisterType(typeof(object));



        [Benchmark(Description = "RegisterType(type, name)")]
        [BenchmarkCategory("Register", "Type", "RegisterType", "IUnityContainer")]
        public object RegisterTypeNamed() => Container.RegisterType(typeof(object), "name");



        [Benchmark(Description = "RegisterType(IService, Service)")]
        [BenchmarkCategory("Register", "Type", "RegisterType", "IUnityContainer")]
        public object RegisterTypeMap() => Container.RegisterType(typeof(IService), typeof(Service));
    }
}
