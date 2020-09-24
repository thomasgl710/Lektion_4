using Door;
using NUnit.Framework;

namespace uut.test.unit
{
    [TestFixture]
    public class Tests
    {
        private DoorControl _uut;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}