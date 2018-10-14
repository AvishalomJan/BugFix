using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IMobile
    {
    }

    class IPhone : IMobile{
        public IPhone()
        {
            Console.WriteLine("Hello IPhone!" );
        }
    }

    class Android : IMobile
    {
        public Android()
        {
            Console.WriteLine("Hello Android!");
        }
    }
}


