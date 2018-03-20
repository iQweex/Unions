using System;

namespace Qweex.Unions.Kind3
{
    public sealed class Union<T0, T1, T2> : TUnion<T0, T1, T2>
    {
        public Union(T0 value) : base(value)
        {
        }

        public Union(T1 value) : base(value)
        {
        }

        public Union(T2 value) : base(value)
        {
        }

        public Union(Func<TUnion<T0, T1, T2>> factory) : base(factory)
        {
        }
    }
}