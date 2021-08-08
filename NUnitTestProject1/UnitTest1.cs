using NUnit.Framework;
using SimpleWebApi.BLL;
using SimpleWebApi.Model;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddFunction()
        {
            var addItems = new AddItems()
            {
                item1 = 1,
                item2 = 10

            };
            var resultValue = new AddFunction().Add(addItems);
            Assert.AreEqual(11, resultValue.Value);
        }
       
    }
}