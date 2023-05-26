using BenchmarkDotNet.Attributes;

namespace Unity.Benchmarks
{
    public partial class ResolutionBenchmarks : BenchmarksBase
    {
        public override void IterationSetup()
        {
            base.IterationSetup();

            Container.RegisterType(typeof(Service));
            Container.RegisterType(typeof(Service), Name);
        }
    }
}
