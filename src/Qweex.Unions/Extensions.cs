using System;

namespace Qweex.Unions
{
    public static class Union
    {
        public static TResult Match<TResult, T0, T1>(
            this TUnion<T0, T1> u,
            Func<T0, TResult> f0,
            Func<T1, TResult> f1
        )
        {
            var (val, ind) = u.Value();
            switch (ind)
            {
                case 0:
                    return f0((T0)val);
                case 1:
                    return f1((T1)val);
                default:
                    throw new Exception("can't match"); 
            }
        }

        public static TResult Match<TResult, T0, T1, T2>(
            this TUnion<T0, T1, T2> u,
            Func<T0, TResult> f0,
            Func<T1, TResult> f1,
            Func<T2, TResult> f2
        )
        {
            return u.Match(
                ab => ab.Match(f0, f1),
                f2
            );
        }
    }
}