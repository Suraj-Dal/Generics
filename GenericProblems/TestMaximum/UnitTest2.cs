using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class UnitTest2
    {
        [Test]
        public void GivenMaxInFirstPosition_TestMaximum_ReturnMaxInFirstPosition()
        {
            double a = 9.5, b = 8.2, c = 7.6;
            GenericProblems.Generic<double> maxDouble = new GenericProblems.Generic<double>(a, b, c);
            var Result = maxDouble.showMax();
            Assert.AreEqual(a, Result);
        }
        [Test]
        public void GivenMaxInSecondPosition_TestMaximum_ReturnMaxInSecondPosition()
        {
            double a = 8.1, b = 9.4, c = 7.3;
            GenericProblems.Generic<double> maxDouble = new GenericProblems.Generic<double>(a, b, c);
            var Result = maxDouble.showMax();
            Assert.AreEqual(b, Result);
        }
        [Test]
        public void GivenMaxInThirdPosition_TestMaximum_ReturnMaxInThirdPosition()
        {
            double a = 8.5, b = 9.2, c = 10.0;
            GenericProblems.Generic<double> maxDouble = new GenericProblems.Generic<double>(a, b, c);
            var Result = maxDouble.showMax();
            Assert.AreEqual(c, Result);
        }
    }
}
