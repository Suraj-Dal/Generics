using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class UnitTest3
    {
        [Test]
        public void GivenMaxInFirstPosition_TestMaximum_ReturnMaxInFirstPosition()
        {
            string a = "Peach", b = "Apple", c = "Banana";
            GenericProblems.Generic<string> maxString = new GenericProblems.Generic<string>(a, b, c);
            var Result = maxString.showMax();
            Assert.AreEqual(a, Result);
        }
        [Test]
        public void GivenMaxInSecondPosition_TestMaximum_ReturnMaxInSecondPosition()
        {
            string a = "Apple", b = "Peach", c = "Banana";
            GenericProblems.Generic<string> maxString = new GenericProblems.Generic<string>(a, b, c);
            var Result = maxString.showMax();
            Assert.AreEqual(b, Result);
        }
        [Test]
        public void GivenMaxInThirdPosition_TestMaximum_ReturnMaxInThirdPosition()
        {
            string a = "Banana", b = "Apple", c = "Peach";
            GenericProblems.Generic<string> maxString = new GenericProblems.Generic<string>(a, b, c);
            var Result = maxString.showMax();
            Assert.AreEqual(c, Result);
        }
    }
}
