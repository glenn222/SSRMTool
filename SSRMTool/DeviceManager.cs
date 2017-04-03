using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace SSRMTool
{
    public class DeviceManager
    {
        private GwyddionLibraryAdapter gwyAdapter;
        private DeviceImage dImage;
        private DeviceMap dMap;
        private Staircase staircase;
        private String relation; // Resistivty vs R or Resistivity Vs dR ... 
        private String path;
        private String channelName;
        public Dictionary<int, String> FuncIndexToString;
        public Dictionary<int, String> ChannelIndex;


        public DeviceManager()
        {
            gwyAdapter = new GwyddionLibraryAdapter();
            FuncIndexToString = new Dictionary<int, String>();
            FuncIndexToString.Add(0, "Resistance To Resistivity");
            FuncIndexToString.Add(1, "Resistance To Dopants");
            FuncIndexToString.Add(2, "Resistance Amplitude To Resistivity");
            FuncIndexToString.Add(3, "Resistance Amplitude To Dopants");

            ChannelIndex = new Dictionary<int, String>();
            ChannelIndex.Add(0, "Resistance");
            ChannelIndex.Add(1, "Resistance Amplitude");
        }

        public List<String> GetChannelNames(String path)
        {
            this.path = path;
            List<String> names = new List<String>();
            //names = gwyAdapter.GetChannelNames(String path);
            return names;
        }

        public Bitmap GetChannelImage(String channel, int ch)
        {
            this.channelName = channel;
            // channelImage = gwyAdapter.GetChannelData(channelName, path);
            double [,] channelImage = gwyAdapter.GetChannelData("d19_tip11.gwy", ch);
            Bitmap image = BitmapMaker.CreateBitMap(channelImage);
            return image;
        }
        
        // create an enumeration for the functions 

    }
}
