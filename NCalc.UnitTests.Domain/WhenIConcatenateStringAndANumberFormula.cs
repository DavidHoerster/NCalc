using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NCalc.UnitTests.Domain
{
    [Trait("Category", "String Math")]
    public class WhenIConcatenateStringAndANumberFormula
    {
        Expression _expr;
        Object _result;
        public WhenIConcatenateStringAndANumberFormula()
        {
            var w = "Document";
            var x = "2";
            var y = "3";

            _expr = new Expression("[w] + (Num([y]) + Num([z]))");
            _expr.Parameters.Add("w", w);
            _expr.Parameters.Add("x", x);
            _expr.Parameters.Add("y", y);
            _expr.Parameters.Add("z", new Expression("Num([x]) * Num([y])"));

            _result = _expr.Evaluate();
        }

        [Fact]
        public void ItShouldOutputAStringWhilePerformingMatch()
        {
            Assert.IsType<String>(_result);
        }

        [Fact]
        public void TheResultShouldBothEvaluateTheNumberFormulaAndConcatenate()
        {
            Assert.Equal("Document9", _result);     // Document + (3 + (2 * 3)) = "Document9"
        }
    }
}
