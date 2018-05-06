using CallbackContract;
using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress1 = new Uri("http://localhost:30000/mojSerwisTCP");
            ServiceHost mojHost1 = new ServiceHost(typeof(Service1), baseAddress1);

            Uri baseAddress2 = new Uri("http://localhost:20001");
            ServiceHost mojHost2 = new
            ServiceHost(typeof(mojCallbackKalkulator), baseAddress2);
            WSDualHttpBinding mojBanding2 = new WSDualHttpBinding();

            try
            {
                ServiceEndpoint endpoint1 = mojHost1.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "endpoint1");
                ServiceEndpoint endpoint2 = mojHost2.AddServiceEndpoint(typeof(ICallbackKalkulator),
                    mojBanding2, "CallbackKalkulator");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                // Metadane:
                smb.HttpGetEnabled = true;
                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                mojHost2.Description.Behaviors.Add(smb2);

                mojHost1.Description.Behaviors.Add(smb);
                mojHost1.Open();

                mojHost2.Open();
                Console.WriteLine("--->CallbackKalkulator uruchomiony.");

                Console.WriteLine("--->MojSerwis jest uruchomiony.");
                Console.WriteLine("--->Nacisnij <ENTER> aby zakonczyc.\n");
                Console.ReadLine(); //czekam na zamkniecie
                mojHost1.Close();
                mojHost2.Close();
                Console.WriteLine("---> Serwis zakonczyl dzialanie.");
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                mojHost1.Abort();
                mojHost2.Abort();
            }
        }
    }
}
