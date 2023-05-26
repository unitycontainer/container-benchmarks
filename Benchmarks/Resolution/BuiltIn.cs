using BenchmarkDotNet.Attributes;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks
    {
        [Benchmark(Description = "Resolve<object>()")]
        [BenchmarkCategory("resolve", "IUnityContainer")]
        public object ResolveObject()
            => Container.Resolve(typeof(object));


        [BenchmarkCategory("resolve", "IUnityContainer")]
        [Benchmark(Description = "Resolve<IUnityContainer>( )")]
        public object ResolveIUnityContainer()
            => Container.IUnityContainer();
    }
}
