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
    }
}
