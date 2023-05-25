using System;

namespace Unity.Benchmarks
{
    public class TestGeneric<T>
    {
        object _value;

        public TestGeneric(object value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
