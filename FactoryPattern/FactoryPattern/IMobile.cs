using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IMobile
    {
    }

    public class IPhone : IMobile
    {
        public IPhone()
        {
            Console.WriteLine("Hello IPhone!" );
        }
    }

    public class Android : IMobile
    {
        public Android()
        {
            Console.WriteLine("Hello Android!");
        }
    }
}


