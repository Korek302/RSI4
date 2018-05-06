using Client.ServiceReference1;
using Client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client1 = new Service1Client("WSHttpBinding_IService1");
            Console.WriteLine("...wywoluje funkcja 1:");
            client1.Funkcja1("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("...kontynuacja po funkcji 1");
            Console.WriteLine("...wywoluje funkcja 2:");
            client1.Funkcja2("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("...kontynuacja po funkcji 2");
            Console.WriteLine("...wywoluje funkcja 1:");
            client1.Funkcja1("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("...kontynuacja po funkcji 1");
            client1.Close();
            Console.WriteLine("KONIEC KLIENT1");

            Console.WriteLine("\nKLIENT2:");
            CallbackHandler mojCallbackHandler = new CallbackHandler();
            InstanceContext instanceContext = new
            InstanceContext(mojCallbackHandler);
            CallbackKalkulatorClient client2 = new
            CallbackKalkulatorClient(instanceContext);
            double value1 = 10;
            Console.WriteLine("...wywoluje Silnia({0})...", value1);
            client2.Silnia(value1);
            value1 = 20;
            Console.WriteLine("...wywoluje Silnia({0})...", value1);
            client2.Silnia(value1);
            int value2 = 2;
            Console.WriteLine("...wywoluje obliczenia cosia...");
            client2.ObliczCos(value2);
            Console.WriteLine("...czekam chwile na odbior wynikow");
            Thread.Sleep(5000);
            client2.Close();
            Console.WriteLine("KONIEC KLIENT2");
        }
    }
}
