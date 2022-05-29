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
            double[] arr = {5.2, 3.2, 8.4, 6.1, 2.2};
            GenericProblems.Generic<double> maxDouble = new GenericProblems.Generic<double>(arr);
            var Result = maxDouble.showMax();
            Assert.AreEqual(arr[4], Result);
        }
    }
}
