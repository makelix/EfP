using static Utilities;

namespace UtilitiesTests
{
    [TestClass]
    public class UtilitiesTests
    {
        private const string Prompt = "Prompt: ";

        [TestMethod]
        public void TestMethod1()
        {
            StringWriter sw = new();
            Console.SetOut(sw);

            Console.SetIn(new StringReader("\n"));
            string answer = Utilities.AskForString(Prompt, false, "Jee.");

            Assert.AreEqual(Prompt, sw.ToString());
            Assert.AreEqual("Jee.", answer);
        }
    }
}