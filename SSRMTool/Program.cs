using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SSRMTool
{
    class Program
    {
        public static void Main(string[] args)
        {
            GwyddionLibraryAdapter wrapper = new GwyddionLibraryAdapter();
            //var res = wrapper.GetConnectSession(0, "key", '3');
            var res = wrapper.TestGwyddionSession(0, "key", '3');
            //var res = wrapper.TestGwyddionSession();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
