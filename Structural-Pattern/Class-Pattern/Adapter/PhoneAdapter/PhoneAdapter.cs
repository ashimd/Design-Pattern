using System;

namespace Adapter.PhoneAdapter
{
    interface IFormatIPhone
    {
        void Recharge();
        void UseLightning();
    }

    interface IFormatAndroid
    {
        void Recharge();
        void UseMicroUsb();
    }

    // Adaptee
    class IPhone : IFormatIPhone
    {
        bool connectorOk = false;

        public void UseLightning()
        {
            connectorOk = true;
            Console.WriteLine("Lightning Connected");
        }

        public void Recharge()
        {
            if (connectorOk)
            {
                Console.WriteLine("Recharge Started");
                for (int _charge = 10; _charge <= 100; _charge += 30)
                {
                    Console.WriteLine("Recharge {0}%", _charge);
                }
                Console.WriteLine("Recharge Finished");
            }
            else
                Console.WriteLine("Connect Lightning first");
        }
    }

    // Adapter
    class IPhoneAdapter : IFormatAndroid
    {
        IFormatIPhone mobile;

        public IPhoneAdapter(IFormatIPhone _mobile)
        {
            mobile = _mobile;
        }

        public void Recharge()
        {
            mobile.Recharge();
        }

        public void UseMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            mobile.UseLightning();
        }
    }

    class Android : IFormatAndroid
    {
        bool connectorOk = false;

        public void UseMicroUsb()
        {
            connectorOk = true;
            Console.WriteLine("MicroUsb connected");
        }

        public void Recharge()
        {
            if (connectorOk)
            {
                Console.WriteLine("Recharge Started");
                for (int _charge = 10; _charge <= 100; _charge += 10)
                {
                    Console.WriteLine("Recharge {0}%", _charge);
                }
                Console.WriteLine("Recharge Finished");
            }
            else
                Console.WriteLine("Connect MicroUsb first");
        }
    }

    // Client
    class MicroUsbRecharger
    {
        IFormatIPhone phone;
        IFormatAndroid phoneAdapter;

        public MicroUsbRecharger()
        {
            Console.WriteLine("Recharging iPhone with Generic Recharger\n");
            phone = new IPhone();
            phoneAdapter = new IPhoneAdapter(phone);
            phoneAdapter.UseMicroUsb();
            phoneAdapter.Recharge();
            Console.WriteLine("iPhone Ready for use\n");
        }
    }

    class IPhoneRecharger
    {
        IFormatIPhone phone;

        public IPhoneRecharger()
        {
            Console.WriteLine("Recharging iPhone with iPhone Recharger\n");
            phone = new IPhone();
            phone.UseLightning();
            phone.Recharge();
            Console.WriteLine("iPhone Ready for use\n");
        }
    }

    class AndroidRecharger
    {
        IFormatAndroid phone;

        public AndroidRecharger()
        {
            Console.WriteLine("Recharging Android Phone with Generic Recharger\n");
            phone = new Android();
            phone.UseMicroUsb();
            phone.Recharge();
            Console.WriteLine("Android Phone Ready for use\n");
        }
    }
}
