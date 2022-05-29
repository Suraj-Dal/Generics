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
            string[] arr = {"Apple", "Peach", "Banana", "Orange", "Guava"};
            GenericProblems.Generic<string> maxString = new GenericProblems.Generic<string>(arr);
            var Result = maxString.showMax();
            Assert.AreEqual(arr[4], Result);
        }
    }
}
