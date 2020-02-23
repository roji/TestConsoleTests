using System;
using NUnit.Framework;

namespace NUnitTests
{
    public class NUnitTests
    {
        [Test]
        public void ConsoleTest()
        {
            Console.WriteLine("Hello world from NUnit (stdout)");
            Console.WriteLine("Hello world from NUnit (stderr)");
        }
    }
}
