using System;

namespace Qweex.Unions.Tests
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

        public Foo(Func<TUnion<TUnion<A, B>, C>> factory) : base(factory)
        {
        }
    }
}