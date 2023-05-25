using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;
using System.IO;
using System.Reflection;
using Unity.Benchmarks;

namespace Unity.Benchmark
{
    class Program
    {
        static IConfig GetGlobalConfig()
            => DefaultConfig.Instance
                .AddJob(Job.Default.AsDefault())
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);


        static void Main(string[] args)
        {

            BenchmarkSwitcher.FromAssemblies(new[] 
            {
                typeof(Benchmarks.ResolutionBenchmarks).Assembly,
            }).Run(args);
        }
    }
}
