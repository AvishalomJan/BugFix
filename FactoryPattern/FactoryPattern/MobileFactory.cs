using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class MobileFactory
    {
        public abstract IMobile CreateMobileDevice();
    }

    public class IPhoneCreator : MobileFactory
    {
        public override IMobile CreateMobileDevice()
        {
            return new IPhone();
        }
    }

    public class AndroidCreator : MobileFactory
    {
        public override IMobile CreateMobileDevice()
        {
            return new Android();
        }
    }
}
