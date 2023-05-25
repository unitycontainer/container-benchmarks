using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Unity.Benchmarks
{
    public partial class PipelineBenchmarks
    {
        protected ContainerAdapter Container;

        [Params("v4", "v5", "v6", "v8")]
        public string Unity;

        [IterationSetup]
        public void IterationSetup()
        {
            var path = Path.GetFullPath($"..\\..\\..\\..\\..\\Adapters\\Container.{Unity}", 
                       Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            Directory.SetCurrentDirectory(path);

            var type = Assembly.LoadFrom($"Container.{Unity}.dll")
                               .GetType($"Unity.{Unity}.UnityAdapter");

            Container = (ContainerAdapter)Activator.CreateInstance(type);
        }


        public interface IService { }

        public class Service : IService { }
        
        public class OtherService : IService { }

        public class CompleteService : IService { }


        //public class EveryTimeManager : LifetimeManager, ITypeLifetimeManager
        //{
        //    public override ResolutionStyle Style => ResolutionStyle.EveryTime;

        //    protected override LifetimeManager OnCreateLifetimeManager() => throw new NotSupportedException();

        //    public override void SetValue(object newValue, ICollection<IDisposable> scope) { }

        //    public override object TryGetValue(ICollection<IDisposable> scope)
        //    {
        //        Pipeline = null;
        //        return UnityContainer.NoValue;
        //    }
        //    public override object GetValue(ICollection<IDisposable> scope)
        //    {
        //        Pipeline = null;
        //        return UnityContainer.NoValue;
        //    }
        //}

        //public class OnceInLifetimeManager : LifetimeManager, ITypeLifetimeManager
        //{
        //    public override ResolutionStyle Style => ResolutionStyle.OnceInLifetime;

        //    protected override LifetimeManager OnCreateLifetimeManager() => throw new NotSupportedException();

        //    public override void SetValue(object newValue, ICollection<IDisposable> lifetime)
        //    { }
        //    public override object TryGetValue(ICollection<IDisposable> lifetime)
        //    {
        //        Pipeline = null;
        //        return UnityContainer.NoValue;
        //    }
        //    public override object GetValue(ICollection<IDisposable> lifetime)
        //    {
        //        Pipeline = null;
        //        return UnityContainer.NoValue;
        //    }
        //}

        //public class OnceInAWhileManager : LifetimeManager, ITypeLifetimeManager
        //{
        //    public override ResolutionStyle Style => ResolutionStyle.OnceInWhile;

        //    protected override LifetimeManager OnCreateLifetimeManager() => throw new NotSupportedException();

        //    public override void SetValue(object newValue, ICollection<IDisposable> lifetime)
        //    { }
        //    public override object TryGetValue(ICollection<IDisposable> lifetime)
        //    {
        //        Pipeline = null;
        //        return UnityContainer.NoValue;
        //    }
        //    public override object GetValue(ICollection<IDisposable> lifetime)
        //    {
        //        Pipeline = null;
        //        return UnityContainer.NoValue;
        //    }
        //}
    }
}
