using Door;
using NSubstitute;
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
        
    }
}