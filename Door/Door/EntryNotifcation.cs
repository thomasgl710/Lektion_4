using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{
    public class EntryNotifcation : IEntryNotifcation
    {

        public void NotifyEntryGranted()
        {


        }

        public void NotifyEntryDenied()
        {
            Console.WriteLine("Hej");
        }
        
    }
}
