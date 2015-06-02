using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NCalc.UnitTests.Domain
{
    [Trait("Category", "String Math")]
    public class WhenIAddTwoDecimalsThatAreStrings
    {
        Expression _expr;
        Object _result;
        public WhenIAddTwoDecimalsThatAreStrings()
        {
            var x = "2.3";
            var y = "3.7";

            _expr = new Expression("Num([x]) + Num([y])");
            _expr.Parameters.Add("x", x);
            _expr.Parameters.Add("y", y);

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
            Assert.Equal(6m, _result);
        }
    }
}