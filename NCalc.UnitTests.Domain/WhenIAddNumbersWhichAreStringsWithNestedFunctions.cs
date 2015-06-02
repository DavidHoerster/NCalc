using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NCalc.UnitTests.Domain
{
    [Trait("Category", "String Math")]
    public class WhenIAddNumbersWhichAreStringsWithNestedFunctions
    {
        Expression _expr;
        Object _result;
        public WhenIAddNumbersWhichAreStringsWithNestedFunctions()
        {
            var x = "2";
            var y = "3";
            var z = "4";

            _expr = new Expression("Num([x]) + (Num([y]) + Num([z]))");
            _expr.Parameters.Add("x", x);
            _expr.Parameters.Add("y", y);
            _expr.Parameters.Add("z", new Expression("Num([x]) * Num([y])"));

            _result = _expr.Evaluate();
        }

        [Fact]
        public void ItShouldCastTheStringsToNumbers()
        {
            Assert.IsType<Decimal>(_result);
        }

        [Fact]
        public void TheResultShouldAddNotConcatenate()
        {
            Assert.Equal(11m, _result);     // 2 + (3 + (2 * 3)) = 11
        }
    }
}
