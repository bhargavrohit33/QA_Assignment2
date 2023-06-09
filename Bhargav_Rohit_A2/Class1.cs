using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using NUnit.Framework;
using TriangleSolver;
namespace Bhargav_Rohit_A2
{

    public class Class1
    {
        [TestFixture]
        public class TriangleTest1
        {

            [Test]
            public void ValidEquilateralTriangle_Input5and5and5_ReturnsEquilateral()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
            }
            [Test]
            public void ValidIsoscelesTriangle_Input6and5and6_ReturnsIsosceles()
            {
                // Arrange
                int firstSide = 6;
                int secondSide = 5;
                int thirdSide = 6;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }

            [Test]
            public void ValidIsoscelesTriangle_Input9and7and7_ReturnsIsosceles()
            {
                // Arrange
                int firstSide = 9;
                int secondSide = 7;
                int thirdSide = 7;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }

            [Test]
            public void ValidIsoscelesTriangle_Input5and7and7_ReturnsIsosceles()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 7;
                int thirdSide = 7;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
            }
            [Test]
            public void ValidScaleneTriangle_Input3and4and5_ReturnsScalene()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ValidScaleneTriangle_Input7and10and12_ReturnsScalene()
            {
                // Arrange
                int firstSide = 7;
                int secondSide = 10;
                int thirdSide = 12;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ValidScaleneTriangle_Input5and9and11_ReturnsScalene()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 9;
                int thirdSide = 11;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ValidScaleneTriangle_Input8and15and17_ReturnsScalene()
            {
                // Arrange
                int firstSide = 8;
                int secondSide = 15;
                int thirdSide = 17;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ValidScaleneTriangle_Input5and12and13_ReturnsScalene()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 12;
                int thirdSide = 13;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }
            [Test]
            public void ValidScaleneTriangle_Input0and3and4_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 3;
                int thirdSide = 4;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthForTwoSides_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 1;
                int secondSide = 0;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
            }

            [Test]
            public void AnalyzeTriangle_ZeroLengthForAllSides_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
            }
            [Test]
            public void AnalyzeTriangle_InvalidResponse_TriangleInequalityViolation_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 1;
                int thirdSide = 8;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }

            [Test]
            public void AnalyzeTriangle_InvalidResponse_NegativeSideLengths_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 4;
                int secondSide = -2;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }

            [Test]
            public void AnalyzeTriangle_InvalidResponse_SumOfTwoSidesEqualsThirdSide_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 6;
                int secondSide = 10;
                int thirdSide = 4;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }
           



        }
    }
}
      
