using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSIS425;
using CSIS425.Models;

namespace CSIS425.Tests.ModelTesting
{
    [TestFixture]
    class ModelCoursesTesting
    {

        //Not sure how to test Guid

        [Test]
        public void HolesTest()
        {
            Model_Courses c = new Model_Courses();
            c.holes = 9;
            Assert.AreEqual(9, c.holes);
        }

        [Test]
        public void ParTest()
        {
            Model_Courses c = new Model_Courses();
            c.pars = "3,3,4";
            Assert.AreEqual("3,3,4", c.pars);
        }

        [Test]
        public void NameTest()
        {
            Model_Courses c = new Model_Courses();
            c.name = "Hoffman";
            Assert.AreEqual("Hoffman", c.name);
        }
    }
}
