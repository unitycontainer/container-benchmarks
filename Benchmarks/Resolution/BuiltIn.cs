using BenchmarkDotNet.Attributes;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks
    {
        [BenchmarkCategory("resolve", "IUnityContainer")]
        [Benchmark(Description = "Resolve<IUnityContainer>( )")]
        public object ResolveIUnityContainer()
            => Container.IUnityContainer();
    }
}
