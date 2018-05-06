using Client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class CallbackHandler : ICallbackKalkulatorCallback
    {
        public void ZwrotSilnia(double result)
        {
            //tu mozna wykorzystać result
            Console.WriteLine(" Silnia = {0}", result);
        }
        public void ZwrotObliczCos(string info)
        {
            //tu mozna wykorzystać info
            Console.WriteLine(" Obliczenia: {0}", info);
        }
    }
}
