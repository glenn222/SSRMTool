using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using NCalc;


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
        private double[,] channelImage;
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
            //TODO: still need to figure thsi out ... 
            this.path = path;
            List<String> names = new List<String>();
            //names = gwyAdapter.GetChannelNames(String path);
            return names;
        }

        public async Task<Bitmap> GetChannelImage(String channel, int ch)
        {
            this.channelName = channel;
            int index = 3;
            if (ch == 1)
                index = 5;
            // channelImage = gwyAdapter.GetChannelData(channelName, path);
            this.channelImage = gwyAdapter.GetChannelData("d19_tip11.gwy", index);
            Bitmap image = await BitmapMaker.CreateBitMap(channelImage);

            return image;
        }

        public async Task<Bitmap> CalculateNewImage(Measurement meas, int FuncIndex, IList<List<int[]>> regions, string material)
        {
            String function = meas.FunctionStrings[FuncIndex];
            DeviceMap dMap = new DeviceMap(this.channelImage, function);
            Expression e = new Expression(function);
            
            foreach (var region in regions)
            {
                dMap.AddRegion(e, region, material);
            }
            
            double[,] newImageValues = await dMap.Calculate().ConfigureAwait(false);
            bool state = gwyAdapter.WriteNewFile(newImageValues, "d19_tip11_new.gwy");

            if (state)
                 return await BitmapMaker.CreateBitMap(newImageValues).ConfigureAwait(false);

            return null;
        }

    }
}
