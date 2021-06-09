using CS_TestingApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CS_TestProject
{
    [TestFixture]
    public class DemoTests
    {
        List<EmployeeDetails> li;
        [Test]
        public void Checkdetails()
        {
            Program pobj = new Program();
            li = pobj.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.id);
                Assert.IsNotNull(x.Name);
                Assert.IsNotNull(x.salary);
                Assert.IsNotNull(x.Geneder);
            }
        }
        [Test]
        public void TestLogin()
        {
            Program pobj = new Program();
            string x = pobj.Login("Ajit", "1234");
            string y = pobj.Login("", "");
            string z = pobj.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Welcome Admin.", z);
        }
        [Test]
        public void getuserdetails()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(100);
            foreach (var x in p)
            {
                Assert.AreEqual(x.id, 100);
                Assert.AreEqual(x.Name, "Bharat");
            }
        }

        [Test]
        public void AddMethodTest()
        {
            Calculator add = new Calculator();
            int result = add.Add(15, 65);
            Assert.That(result, Is.EqualTo(80));
        }

        [Test]
        [TestCase(15, 35, 50)]
        [TestCase(10, 45, 55)]
        [TestCase(20, 50, 70)]
        public void AddMethodTest(int num1, int num2, int expected)
        {
            Calculator add = new Calculator();
            int result = add.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        // Repeat test for 10 times
        [Test]
         
        [Repeat(10)]
        public void AddMethodTest1()
        {
            Calculator add = new Calculator();
            int result = add.Add(16, 24);
            Assert.AreEqual(result, 40);
        }

        // The first test can be to test the happy path:

        [Test]
        public void ReadTemperature()
        {
            var sut = new TemperatureSensor();

            sut.Initialize();

            var temperature = sut.ReadCurrentTemperature();

            Assert.AreEqual(42, temperature);
        }

        // Next, a test can be written to check that the expected exception is thrown:

        [Test]
        public void ErrorIfReadingBeforeInitialized()
        {
            var sut = new TemperatureSensor();

            Assert.Throws<InvalidOperationException>(() => sut.ReadCurrentTemperature());
        }

        // Notice in the preceding code that any InvalidOperationException thrown will pass the test. To ensure that the thrown exception is correct, it can be captured and further asserts performed against it:

        [Test]
        public void ErrorIfReadingBeforeInitialized_CaptureExDemo()
        {
            var sut = new TemperatureSensor();

            var ex = Assert.Throws<InvalidOperationException>(() => sut.ReadCurrentTemperature());

            Assert.AreEqual("Cannot read temperature before initializing.", ex.Message);
            // or:
            Assert.That(ex.Message, Is.EqualTo("Cannot read temperature before initializing."));
        }
    }
}
