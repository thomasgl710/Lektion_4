using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Door
{
   
    public class DoorControl
    {
        IDoors _doors = new Doors();
        IUserValidation _userValidation = new UserValidation();
        IEntryNotifcation _entryNotifcation = new EntryNotifcation();
        void RequestEntry(string id)
        {
          bool validate =  _userValidation.ValidateEntryRequest(id);
          if (validate == true)
          {
              _doors.Open();
              _entryNotifcation.NotifyEntryGranted();

              Thread.Sleep(1000);
          }
          else
          {
              _entryNotifcation.NotifyEntryDenied();
          }
        }

        void DoorOpen()
        {
            
        }

        void DoorClosed()
        {

        }
   
    }
}
