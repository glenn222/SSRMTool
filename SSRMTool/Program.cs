using System;
using System.Collections.Generic;
using NCalc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SSRMTool
{
    class Program
    {
        public static int Main(string[] args)
        {
            GwyddionLibraryAdapter wrapper = new GwyddionLibraryAdapter();
            var res = wrapper.GetChannelData("d19_tip11.gwy",3);
            bool success = wrapper.WriteNewFile(res, "");
            Console.WriteLine(res.Length);
            Console.WriteLine(success);
            Console.WriteLine(res[0,0]);
            Console.ReadKey();
            return 0;
        }
    }
}
