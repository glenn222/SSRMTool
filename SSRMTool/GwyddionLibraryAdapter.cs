using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SSRMTool
{
    public class GwyddionLibraryAdapter
    {

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern bool WriteGWY(IntPtr newimagedata,int xres, int yres);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern bool WriteGWYChannel(char* path, IntPtr newimagedata, int xres, int yres);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern IntPtr ReadGWYChannelData(char* path,int id,int *resX, int *resY);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern IntPtr ReadGWYChannelNames(char* path, int* n);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern IntPtr CreateArray(int length);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern bool DestroyArray(IntPtr used_array);

        public unsafe int[] GetChannelList(string path)
        {
            char* char_path;
            fixed (char* bptr = path)
            {
                char_path = (char*)bptr;
            }

            int n=0;
            IntPtr channels_ptr;
            channels_ptr = ReadGWYChannelNames(char_path,&n);
            int[] channels = new int[n];
            Marshal.Copy(channels_ptr, channels, 0, n);
            return channels;
        }
        public unsafe double[,] GetChannelData(string path,int id)
        {
            char* char_path;
            fixed (char* bptr = path)
            {
                char_path = (char*)bptr;
            }
            IntPtr data_ptr;
            int xres, yres;
            data_ptr = ReadGWYChannelData(char_path, id, &xres, &yres);
            double[] data = new double[xres * yres];
            Marshal.Copy(data_ptr, data, 0, xres * yres);
            double[,] matrix_data = new double[xres, yres];
            for (int i = 0; i < xres; i++)
            {
                for (int j = 0; j < yres; j++)
                {
                    matrix_data[i, j] = data[i * yres + j];
                }
            }
            return matrix_data;
        }
        public unsafe bool WriteNewFile(double[,] imagedata,string filename)
        {
            int xres, yres;
            xres = imagedata.GetLength(0);
            yres = imagedata.GetLength(1);
            double[] linearized = new double[xres * yres];
            for (int i = 0; i < xres; i++)
            {
                for (int j = 0; j < yres; j++)
                {
                    linearized[i * yres + j] = imagedata[i, j];
                }
            }
            IntPtr ptr_input= CreateArray(xres * yres);
            Marshal.Copy(linearized, 0, ptr_input, xres * yres);
            return WriteGWY(ptr_input, xres, yres);
        }
        public unsafe bool WriteNewChannel(double[,] imagedata,string filename)
        {
            //broken
            int xres, yres;
            xres = imagedata.GetLength(0);
            yres = imagedata.GetLength(1);
            double[] linearized = new double[xres * yres];
            for (int i = 0; i < xres; i++)
            {
                for (int j = 0; j < yres; j++)
                {
                    linearized[i * yres + j] = imagedata[i, j];
                }
            }
            char* char_path;
            fixed (char* bptr = filename)
            {
                char_path = (char*)bptr;
            }
            IntPtr ptr_input = CreateArray(xres * yres);
            Marshal.Copy(linearized, 0, ptr_input, xres * yres);
            return WriteGWYChannel(char_path, ptr_input, xres, yres);
        }
    }
}
