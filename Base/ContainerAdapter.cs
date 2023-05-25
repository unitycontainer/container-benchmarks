using System;

namespace Unity.Benchmarks
{
    public abstract class ContainerAdapter
    {
        public abstract object Resolve(Type type);

        public abstract object IUnityContainer();
    }
}
