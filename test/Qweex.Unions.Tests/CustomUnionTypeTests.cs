using Qweex.Unions.Tests.Common;
using Xunit;

namespace Qweex.Unions.Tests
{
    public class CustomUnionTypeTests
    {
        [Fact]
        public void Test_case_1_2()
        {
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
        }
    }
}
