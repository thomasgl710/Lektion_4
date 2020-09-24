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

        public void Close()
        {
            Console.WriteLine("Door has been closed");
        }

    }
}
