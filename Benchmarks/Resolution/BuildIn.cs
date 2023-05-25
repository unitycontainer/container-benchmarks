using BenchmarkDotNet.Attributes;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks
    {
        [Benchmark(Description = "IUnityContainer<object>()")]
        [BenchmarkCategory("resolve", "object", "IUnityContainer")]
        public object Resolve_Object_IUnityContainer()
            => Container.Resolve(typeof(object));
        

        [Benchmark(Description = "IUnityContainer<IUnityContainer>( )")]
        public object Resolve_IUnityContainer_IUnityContainer()
            => Container.IUnityContainer();
    }
}
