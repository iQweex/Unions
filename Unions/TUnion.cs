using System;

namespace Unions
{
    public abstract class TUnion<T0, T1>
    {
        private readonly Func<(object, byte)> _lazyValue;

        public TUnion(Func<TUnion<T0, T1>> factory)
            : this(() => factory().Value()) { }

        public TUnion(T0 value) : this(() => (value, 0)) { }

        public TUnion(T1 value) : this(() => (value, 1)) { }

        private TUnion(Func<(object, byte)> lazyValue)
        {
            _lazyValue = lazyValue;
        }
        public (object, byte) Value() => _lazyValue();
    }
}
