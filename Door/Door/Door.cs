using System;
using System.Collections.Generic;
using System.Text;

namespace Door
{


    //hej
    public class Doors : IDoors
    {
        public void Open()
        {
            Console.WriteLine("Door is opening");
        }

        public void Closed()
        {
            Console.Writeline("Door has been closed")
        }

    }
}
