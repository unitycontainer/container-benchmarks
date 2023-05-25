using System;
using System.Collections.Generic;
using System.Text;

namespace Unity.Benchmarks
{
    public interface IService<T> { }

    public class Service<T> : IService<T> { }
}
