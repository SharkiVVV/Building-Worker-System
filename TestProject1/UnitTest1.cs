namespace TestProject1
   
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class WACTests
        {
            [TestMethod]
            public void Security_CorrectPassword_ReturnsZero()
            {
                
                Program.W_A_C wac = new Program.W_A_C();
                var stringReader = new StringReader("qwer");
                Console.SetIn(stringReader);

                
                int result = wac.Security();

                
                Assert.AreEqual(0, result);
            }

            [TestMethod]
            public void Security_IncorrectPassword_PromptsAgain()
            {
                
                Program.W_A_C wac = new Program.   W_A_C();
                var stringReader = new StringReader("wrong\nqwer");
                Console.SetIn(stringReader);

               
                int result = wac.Security();

                
                Assert.AreEqual(0, result);
            }

        }
    }
}
    