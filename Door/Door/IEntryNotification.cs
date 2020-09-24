using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{
    interface IEntryNotifcation
    {
        void NotifyEntryGranted();
        void NotifyEntryDenied();
    }
}
