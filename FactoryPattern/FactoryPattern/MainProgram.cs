using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class MainProgram
    {
        static void Main()
        {
            IPhoneCreator iphoneFactory = new IPhoneCreator();
            AndroidCreator androidFactory = new AndroidCreator();

            IMobile mobileDevice = androidFactory.CreateMobileDevice();
        }

    }

}
