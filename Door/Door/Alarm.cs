using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{
    public class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("Alarm is raised motherfuckers");
        }
    }
}
