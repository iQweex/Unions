using System;
using Qweex.Unions.Kind3;

namespace Qweex.Unions.Tests.Common
{
    public class Foo : TUnion<A, B, C>
    {
        public Foo(A value) : base(value)
        {
        }

        public Foo(B value) : base(value)
        {
        }

        public Foo(C value) : base(value)
        {
        }

        public Foo(Func<TUnion<A, B, C>> factory) : base(factory)
        {
        }
    }
}