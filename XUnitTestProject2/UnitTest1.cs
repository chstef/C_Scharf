
using ConsoleApp1;
using FluentAssertions;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            // Arrange
            Class1 calc = new Class1();

            // Act
            int itest = calc.GetAdd();

            // Assert 
            // Console.WriteLine("Hello World!" + i);
            // Assert.Equal(2, i);
            itest.Should().Be(2);
            calc.AddCalc("1,2").Should().Be(3);
            calc.AddCalc("1").Should().Be(1);
            calc.AddCalc("").Should().Be(0);
            calc.AddCalc(" [ 1 , 2 ] ").Should().Be(3);
            calc.AddCalc(" [ 1 , 2 , 34 ] ").Should().Be(37);
        }
        [Fact]
        public void Test2()
        {

            // Arrange
            Class1 calc = new Class1();
            // Act
            int h = calc.AddCalc("[1,4,5]");
            // Assert 
            h.Should().Be(10);
        }
        [Fact]
        public void Test3()
        {
            char delm = '\n';
            // Arrange
            Class1 clalc = new Class1(delm);
            // Act
            int h = clalc.AddCalc("[1" + (delm) + "4" + (delm) + "5]");
            // Assert 
            h.Should().Be(10);
        }
        [Fact]
        public void Test4()
        {
            char delm = '\n'; char delm2 = ','; char delm3 = ';';
            // Arrange
            Class1 clalc = new Class1("\n;,");
            // Act
            int h = clalc.AddCalc("[1" + (delm2) + "2" + (delm3) + "4" + (delm) + "5" + (delm3) + "6" + (delm2) + "7" + (delm2) + "8" + (delm) + "9" + (delm3) + "3]");
            // Assert 

            h.Should().Be(45);
        }
        [Fact]
        public void Test5()
        {
            char delm = '\n';
            // Arrange
            Class1 clalc = new Class1(delm);
            // Act
            int h = clalc.AddCalc("[1" + (delm) + "4" + (delm) + "-5]");
            // Assert 
            h.Should().Be(5);
        }
    }
}
