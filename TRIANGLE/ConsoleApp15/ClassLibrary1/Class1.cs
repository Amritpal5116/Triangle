using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangle;
using NUnit.Framework;

namespace TriAssignment
{
    [TestFixture]
    class testcase
    {
        [Test]
        public void Geta4andb4andc4_expectedresultequilateral()
        {

            int a = 4;
            int b = 4;
            int c = 4;
            string expectedResult = "It is Equilateral";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Geta9andb9andc9_expectedresultequilateral()
        {

            int a = 9;
            int b = 9;
            int c = 9;
            string expectedResult = "It is Equilateral";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Geta5andb5andc5_expectedresultequilateral()
        {

            int a = 5;
            int b = 5;
            int c = 5;
            string expectedResult = "It is Equilateral";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Geta9andb7andc3_expectedresultscalene()
        {

            int a = 9;
            int b = 7;
            int c = 3;
            string expectedResult = "It is Scalene";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Geta8andb5andc2_expectedresultscalene()
        {

            int a = 8;
            int b = 5;
            int c = 2;
            string expectedResult = "It is Scalene";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void Geta3andb3andc1_expectedresultisosceles()
        {

            int a = 3;
            int b = 3;
            int c = 1;
            string expectedResult = "It is Isosceles";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Geta3andb1andc3_expectedresultisosceles()
        {

            int a = 3;
            int b = 1;
            int c = 3;
            string expectedResult = "It is Isosceles";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Geta1andb3andc3_expectedresultisosceles()
        {

            int a = 1;
            int b = 3;
            int c = 3;
            string expectedResult = "It is Isosceles";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Geta0andb1andc2_expectedresultinvalidvalue()
        {

            int a = 0;
            int b = 1;
            int c = 2;
            string expectedResult = "It is not a triangle";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Geta2andb4andc6_expectedresultinvalid()
        {

            int a = 2;
            int b = 4;
            int c = 6;
            string expectedResult = "It is not a triangle";
            string actualResult = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}