using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPractice;


namespace UnitTest
{
    [TestClass]
    public class Calculation
    {
        [TestMethod]
        public void Add() 
        {
            // Arrange  -- initialization of an object.
            Program program = new Program();

            // Act -- calling a method from perticular object.
            var result =  program.Add(10,15);
            // Assert -- check test case according to you'r test case.
            Assert.AreEqual(25, result);
           
            // inside a test menue for Enterprise Edition(only for Enterprise Edition) there is a option 'Analyze Code Coverage for all' unit test case , Currently i,am using Community Edition VS2019.
            // VS 2017 Comunity edition have Code coverage feature.
        }

    }
}
