using Door;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;

namespace uut.test.unit
{
    [TestFixture]
    public class Tests
    {
        private DoorControl _uut;
        private IUserValidation _userValidation;
        private IEntryNotifcation _entryNotification;
        private IDoors _doors;
        [SetUp]
        public void Setup()
        {
            _entryNotification = Substitute.For<IEntryNotifcation>();
            _userValidation = Substitute.For<IUserValidation>();
            _doors = Substitute.For<IDoors>();

            _uut = new DoorControl(_doors, _entryNotification, _userValidation);
        }

        [Test]
        public void RequestEntry_ValidateEntryRequestTrue_ReceivedOneOpenDoor()
        {
            string id = " hej";
            _userValidation.ValidateEntryRequest(id).Returns(true);
            _uut.RequestEntry(id);
  
            _doors.Received(1).Open();
        }

        [Test]
        public void test()
        {
            string id = "hej";
            _userValidation.ValidateEntryRequest(id).Returns(true);
            _uut.RequestEntry(id);
            _uut.RequestEntry(id);
            _doors.Received(2).Open();
        }

        [TestCase("a", "a", true)]
        public void test1(string id1, string id2, bool statement)
        {
            _userValidation.ValidateEntryRequest(id1).Returns(statement);
            _uut.RequestEntry(id2);
            _doors.Received(1).Close();
        }

        [TestCase("hej", "hej", false)]
        [TestCase("hej", "nej", true)]
        [TestCase("hej", "nej", false)]
        public void test2(string id, string id2, bool statement)
        {
           
            _userValidation.ValidateEntryRequest(id).Returns(statement);
            _uut.RequestEntry(id2);
            _entryNotification.Received(1).NotifyEntryDenied();
        }
        [TestCase("hej", "hej", true)]
        
        public void test3(string id1, string id2, bool statement)
        {
            _userValidation.ValidateEntryRequest(id1).Returns(statement);
            _uut.RequestEntry(id2);
            _entryNotification.Received(1).NotifyEntryGranted();
        }
        


    }
}