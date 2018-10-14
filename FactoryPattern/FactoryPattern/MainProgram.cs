using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            MobileFactory[] factory = new MobileFactory[2];

            factory[0] = new IPhoneCreator();
            factory[1] = new AndroidCreator();

            foreach(MobileFactory creator in factory)
            {
                creator.CreateMobileDevice();
            }

        }

    }

}
