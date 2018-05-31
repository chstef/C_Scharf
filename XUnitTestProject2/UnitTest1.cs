
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
            Class1 c = new Class1();

            // Act
            int i = c.GetAdd();

            // Assert 
            // Console.WriteLine("Hello World!" + i);
            // Assert.Equal(2, i);
            i.Should().Be(2);
            c.AddCalc("1,2").Should().Be(3);
             c.AddCalc("1").Should().Be(1);
          //  c.AddCalc("").Should().Be(0);

        }
        [Fact]
        public void Test2()
        {

            // Arrange
            Class1 c = new Class1();
            // Act
            int h = c.AddCalc("");
            // Assert 
            h.Should().Be(0);
        }
    }
}
