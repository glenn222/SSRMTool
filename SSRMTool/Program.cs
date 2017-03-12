using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConnectSessionWrapper wrapper = new ConnectSessionWrapper();
            var res = wrapper.GetConnectSession(0, "key", '3');
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
