using BenchmarkDotNet.Attributes;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks : BenchmarksBase
    {
        #region Built-In

        [BenchmarkCategory("resolve", "IUnityContainer")]
        [Benchmark(Description = "Resolve<IUnityContainer>( )")]
        public object ResolveIUnityContainer()
            => Container.IUnityContainer();

        #endregion


        #region Resolution

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

        #endregion


        #region Scaffolding

        public override void IterationSetup()
        {
            base.IterationSetup();

            Container.RegisterType(typeof(Service));
            Container.RegisterType(typeof(Service), Name);
        }

        #endregion
    }
}
