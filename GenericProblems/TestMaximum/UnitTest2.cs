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
            GenericProblems.Generic generic = new GenericProblems.Generic();
            var Result = generic.findMaximum(a, b, c);
            Assert.AreEqual(a, Result);
        }
        [Test]
        public void GivenMaxInSecondPosition_TestMaximum_ReturnMaxInSecondPosition()
        {
            double a = 8, b = 9, c = 7;
            GenericProblems.Generic generic = new GenericProblems.Generic();
            var Result = generic.findMaximum(a, b, c);
            Assert.AreEqual(b, Result);
        }
        [Test]
        public void GivenMaxInThirdPosition_TestMaximum_ReturnMaxInThirdPosition()
        {
            double a = 8, b = 9, c = 10;
            GenericProblems.Generic generic = new GenericProblems.Generic();
            var Result = generic.findMaximum(a, b, c);
            Assert.AreEqual(c, Result);
        }
    }
}
