using Unions;
using Xunit;

namespace Union.Tests
{
    public class UnionTests
    {
        [Fact]
        public void Test_case_1_2()
        {
            Assert
                .Equal(
                    "1",
                    new Union<int, string>(1)
                        .Match(
                            i => i.ToString(),
                            s => s
                        )
                );
            Assert
                .Equal(
                    "2",
                    new Union<int, string>("2")
                        .Match(
                            i => i.ToString(),
                            s => s
                        )
                );

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
