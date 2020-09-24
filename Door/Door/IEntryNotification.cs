using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{
    public interface IEntryNotifcation
    {
        void NotifyEntryGranted();
        void NotifyEntryDenied();
    }
}
