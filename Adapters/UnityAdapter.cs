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
    private readonly UnityContainer _container;

    public UnityAdapter()
    {
        _container = new UnityContainer();
    }

    public override object Resolve(Type type) => _container.Resolve(type);
}
