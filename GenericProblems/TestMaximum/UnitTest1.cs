namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirstPosition_TestMaximum_ReturnMaxInFirstPosition()
        {
            int a = 10, b = 8, c = 9;
            GenericProblems.Generic<int> maxInteger = new GenericProblems.Generic<int>(a, b, c);
            var Result = maxInteger.showMax();
            Assert.AreEqual(a, Result);
        }
        [Test]
        public void GivenMaxInSecondPosition_TestMaximum_ReturnMaxInSecondPosition()
        {
            int a = 7, b = 9, c = 4;
            GenericProblems.Generic<int> maxInteger = new GenericProblems.Generic<int>(a, b, c);
            var Result = maxInteger.showMax();
            Assert.AreEqual(b, Result);
        }
        [Test]
        public void GivenMaxInThirdPosition_TestMaximum_ReturnMaxInThirdPosition()
        {
            int a = 5, b = 8, c = 9;
            GenericProblems.Generic<int> maxInteger = new GenericProblems.Generic<int>(a, b, c);
            var Result = maxInteger.showMax();
            Assert.AreEqual(c, Result);
        }
        
    }
}