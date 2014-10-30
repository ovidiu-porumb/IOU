using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SmokeTest
{
    [TestFixture]
    public class SmokeTest
    {
        [Test]
        public void SmokeTestOne()
        {
            Assert.Fail("Oops");
        }

    }
}
