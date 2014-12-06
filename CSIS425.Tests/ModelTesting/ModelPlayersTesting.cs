using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSIS425;

namespace CSIS425.Tests.ModelTesting
{
    [TestFixture]
    class ModelPlayersTesting
    {
        //Not sure how to test Guids

        [Test]
        public void SoreTesting
        {
            Model_Players p = new Model_Players();
            p.score = "3,4,3";
            Assert.AreEqual("3,4,3", p.score);
        }

    }
}
