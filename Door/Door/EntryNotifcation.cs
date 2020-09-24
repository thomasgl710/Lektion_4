using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{
    public class EntryNotifcation : IEntryNotifcation
    {

        public void NotifyEntryGranted()
        {
            Console.WriteLine("Entry Granted");

        }

        public void NotifyEntryDenied()
        {
            Console.WriteLine("Entry denied");
        }
        
    }
}
