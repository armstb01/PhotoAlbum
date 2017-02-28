using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject3
{
    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            album cu = new album();
            cu.getAlbums("1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string text = "a";
            string actual = "Sorry, we only accept Integers or cash!\r\n";

            var currentConsoleOut = Console.Out;

            album cu = new album();

            using (var consoleOutput = new ConsoleOutput())
            {
                text = cu.getAlbums(text);

                Assert.AreEqual(actual, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string text = "112345";
            string actual = "Sorry, we did not find any albums under that Id.\r\n";

            var currentConsoleOut = Console.Out;

            album cu = new album();

            using (var consoleOutput = new ConsoleOutput())
            {
                text = cu.getAlbums(text);

                Assert.AreEqual(actual, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string text = null;
            string actual = "You get nothin' 4 nothin' . . .  \r\n";

            var currentConsoleOut = Console.Out;

            album cu = new album();

            using (var consoleOutput = new ConsoleOutput())
            {
                text = cu.getAlbums(text);

                Assert.AreEqual(actual, consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}
