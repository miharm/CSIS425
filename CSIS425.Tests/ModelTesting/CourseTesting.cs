using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSIS425;
using CSIS425.Models.Model_Courses;

namespace CSIS425.Tests.ModelTesting
{
    [TestFixture]
    class CourseTesting
    {

        [Test]
        public void HolesTest(){
            Model_Courses c = new Model_Courses();
            c.holes() = 9;
            Assert.AreEqual(9, c.holes());
            

        }
    }
}
