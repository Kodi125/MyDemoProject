using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyDemoProject;

namespace MyDemoProject.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void Test_1()
        {
            //arrange
            Program p1 = new Program();
            //act
            int actualResult = p1.Add(5, 10);
            //assert
            Assert.That(actualResult, Is.EqualTo(15));  //15 is the expected result
        }
        [Test]
        public static void Test_2()
        {
            //arrange
            Program p1 = new Program();
            //act
            int actualResult = p1.Add(8, 14);
            //assert
            Assert.That(actualResult, Is.EqualTo(21));  //22 is the expected result
        }
    }
}
