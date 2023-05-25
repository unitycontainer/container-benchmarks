using BenchmarkDotNet.Attributes;


namespace Unity.Benchmarks
{
    public partial class RegistrationBenchmarks
    {
        [Benchmark(Description = "RegisterInstance(type, instance)")]
        [BenchmarkCategory("Register", "Instance", "RegisterInstance", "IUnityContainer")]
        public object RegisterInstance() => Container.RegisterInstance(typeof(Service), Instance);



        [Benchmark(Description = "RegisterInstance(type, name, instance)")]
        [BenchmarkCategory("Register", "Instance", "RegisterInstance", "IUnityContainer")]
        public object RegisterInstanceNamed() => Container.RegisterInstance(typeof(Service), "name", Instance);
    }
}
