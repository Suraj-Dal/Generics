namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirstPosition_TestMaximum_ReturnMaxInFirstPosition()
        {
            int a = 10, b = 8, c = 9;
            GenericProblems.Generic generic = new GenericProblems.Generic();
            var Result = generic.findMaximum(a, b, c);
            Assert.AreEqual(a, Result);
        }
        [Test]
        public void GivenMaxInSecondPosition_TestMaximum_ReturnMaxInSecondPosition()
        {
            int a = 8, b = 9, c = 7;
            GenericProblems.Generic generic = new GenericProblems.Generic();
            var Result = generic.findMaximum(a, b, c);
            Assert.AreEqual(b, Result);
        }
        [Test]
        public void GivenMaxInThirdPosition_TestMaximum_ReturnMaxInThirdPosition()
        {
            int a = 8, b = 9, c = 10;
            GenericProblems.Generic generic = new GenericProblems.Generic();
            var Result = generic.findMaximum(a, b, c);
            Assert.AreEqual(c, Result);
        }
        
    }
}