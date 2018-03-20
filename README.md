# Qweex.Unions

[![Build status](https://ci.appveyor.com/api/projects/status/juau9eckp6yqfc3l?svg=true)](https://ci.appveyor.com/project/kogoia/unions)
[![NuGet](https://img.shields.io/nuget/dt/Qweex.Unions.svg)](https://www.nuget.org/packages/Qweex.Unions)

Create custom union type

```cs
public class ParsedInt : TUnion<int, Error>
{
    public ParsedInt(string str) 
        : this(() =>
        {
            int a;
            return int.TryParse(str, out a) ? 
                new ParsedInt(a) 
              : 
                new ParsedInt(new Error("Invalid Input"));
        }) {}
        
    // you can generate all ctors with VS, 
    // because TUnion<,> is an abstract class, not interface, and it has own ctors
    // which require overloads
    public ParsedInt(Func<TUnion<int, Error>> factory) : base(factory) {}
    public ParsedInt(int value) : base(value) {}
    public ParsedInt(Error value) : base(value) {}
}
```

And use it

```cs
Assert
    .Equal(
        "27",
        new ParsedInt("27")
            .Match(
                i => i.ToString(),
                e => e.Message
            )
    );

Assert
    .Equal(
        "Invalid Input",
        new ParsedInt("a27")
            .Match(
                i => i.ToString(),
                e => e.Message
            )
    );
```
