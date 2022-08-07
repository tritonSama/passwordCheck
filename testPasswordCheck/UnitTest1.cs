namespace testPasswordCheck
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void passwordLenghTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1("somePassword");


            
            Assert.IsTrue(pass.testLengh());
        }

        [Test]
        public void passwordNotLenghTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1(" ");



            Assert.IsFalse(pass.testLengh());
        }

        [Test]
        public void passwordAlphaTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1("somePassword");



            Assert.IsTrue(pass.testAlpha());
        }

        [Test]
        public void passwordNotAlphaTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1(" ");



            Assert.IsFalse(pass.testAlpha());
        }
        [Test]
        public void passwordNumTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1("1somePassword");



            Assert.IsTrue(pass.testNum());
        }

        [Test]
        public void passwordNotNumTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1(" ");



            Assert.IsFalse(pass.testNum());
        }
        [Test]
        public void passwordTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1("1somePassword");



            Assert.IsTrue(pass.test());
        }

        [Test]
        public void passwordNotTest()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1(" ");



            Assert.IsFalse(pass.test());
        }
        [Test]
        public void passwordNotWithMeassage()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1(" ");



            Assert.IsFalse(pass.test());
            CollectionAssert.Contains(pass.reasons, "Too short");
            CollectionAssert.Contains(pass.reasons, "missing alpha");
            CollectionAssert.Contains(pass.reasons, "missing num");
        }
        [Test]
        public void passwordAdminLengh()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1("passwordtest", true);



            Assert.IsTrue(pass.testLengh());
        }

        [Test]
        public void passwordNotAdminLengh()
        {
            passwordCheck.Class1 pass = new passwordCheck.Class1(" ", true);



            Assert.IsFalse(pass.testLengh());
        }
    }

}