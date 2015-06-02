using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NCalc.UnitTests.Domain
{
    [Trait("Category", "String Math")]
    public class WhenIConcatenateTwoStringsOneOfWhichIsANumber
    {
        Expression _expr;
        Object _result;
        public WhenIConcatenateTwoStringsOneOfWhichIsANumber()
        {
            var x = "Document";
            var y = "1";

            _expr = new Expression("x + y");
            _expr.Parameters.Add("x", x);
            _expr.Parameters.Add("y", y);

            _result = _expr.Evaluate();
        }

        [Fact]
        public void ItShouldCastTheResultToString()
        {
            Assert.IsType<String>(_result);
        }

        [Fact]
        public void TheResultShouldConcatenate()
        {
            Assert.Equal("Document1", _result);
        }
    }
}