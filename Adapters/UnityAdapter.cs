#if UNITY_V4
namespace Unity.v4;

#elif UNITY_V5
namespace Unity.v5;

#elif UNITY_V6
namespace Unity.v6;

#elif UNITY_V7
namespace Unity.v7;

#elif UNITY_V8
namespace Unity.v8;

#else
namespace Unity.vX;
#endif


public class UnityAdapter : ContainerAdapter
{
    private readonly IUnityContainer _container;

    public UnityAdapter() => _container = new UnityContainer();

    public override object IUnityContainer() => _container.Resolve(typeof(IUnityContainer));

    public override object Resolve(Type type) => _container.Resolve(type);

    public override object Resolve(Type type, string name) => _container.Resolve(type, name);


    
    public override object RegisterType(Type type) => _container.RegisterType(null, type, null, null);

    public override object RegisterType(Type type, Type map) => _container.RegisterType(type, map, null, null);

    public override object RegisterType(Type type, string name) => _container.RegisterType(null, type, name, null);



    public override object RegisterInstance(Type type, object instance) => _container.RegisterInstance(type, null, instance);

    public override object RegisterInstance(Type type, string name, object instance) => _container.RegisterInstance(type, name, instance);

}
