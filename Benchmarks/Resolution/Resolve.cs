using BenchmarkDotNet.Attributes;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks
    {
        [Benchmark(Description = "Resolve<object>()")]
        [BenchmarkCategory("resolve", "IUnityContainer")]
        public object ResolveObject()
            => Container.Resolve(typeof(object));


        [Benchmark(Description = "Registered<Service>()")]
        [BenchmarkCategory("resolve", "registered", "IUnityContainer")]
        public object Resolve_Registered_Type()
            => Container.Resolve(typeof(Service));


        [Benchmark(Description = "Registered<Service>(name)")]
        [BenchmarkCategory("resolve", "registered", "IUnityContainer")]
        public object Resolve_Registered_Named()
            => Container.Resolve(typeof(Service), Name);
    }
}
