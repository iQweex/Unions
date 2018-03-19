using System;
using Unions;

namespace Union.Tests
{
    public class ParsedInt : TUnion<int, Error>
    {
        public ParsedInt(string str) 
            : this(() =>
            {
                int a;
                return int.TryParse(str, out a) ? new ParsedInt(a) : new ParsedInt(new Error("Invalid Input"));
            }) {}

        public ParsedInt(Func<TUnion<int, Error>> factory) : base(factory)
        {
        }

        public ParsedInt(int value) : base(value)
        {
        }

        public ParsedInt(Error value) : base(value)
        {
        }
    }
}
