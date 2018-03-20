using System;
using Qweex.Unions.Kind2;

namespace Qweex.Unions.Kind3
{
    public abstract class TUnion<T0, T1, T2> 
        : TUnion<TUnion<T0, T1>, T2>
    {
        protected TUnion(T0 value) : this(new Union<T0, T1>(value)) { }
        protected TUnion(T1 value) : this(new Union<T0, T1>(value)) { }
        protected TUnion(T2 value) : base(value) {}
        protected TUnion(Func<TUnion<T0, T1, T2>> factory)
            : base(() =>
            {
                 return factory()
                    .Match(
                        a => new Union<T0, T1, T2>(a),
                        b => new Union<T0, T1, T2>(b),
                        c => new Union<T0, T1, T2>(c)
                    );
            })
        { }
        private TUnion(TUnion<T0, T1> value) : base(value) {}
    }
}
