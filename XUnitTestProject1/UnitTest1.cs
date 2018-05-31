
using ConsoleApp1;
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
            Class1 c =  new Class1();
                      
            // Act
             int i = c.GetAdd();

            // Assert 
 //Console.WriteLine("Hello World!" + i);
            Assert.Equal(2, i);
            i.Should(2)
        }
    }
}
