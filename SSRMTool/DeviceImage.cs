using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    class DeviceImage
    {
        //Stores information about where the device image was loaded from and what channel was loaded
        //Allows pull and push of images
        public double[,] PullChannel()
        {
            double[,] image = new double[100,100];
            return image;
        }
        public bool SaveChannel(double[,] Image,string ChannelName)
        {
            return true;
        }
    }
}
