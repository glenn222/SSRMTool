using System;
using System.Runtime.InteropServices;

namespace SSRMTool
{
    public class ConnectSessionWrapper
    {
        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 ConnectSession(UInt32 handle,
                                                   char* publicKey,
                                                   char publicKeyLen);
        
        public unsafe UInt32 GetConnectSession(UInt32 handle,
                                               string publicKey,
                                               char publicKeyLen)
        {
            //"Convert" string to char*
            char* pubKey;
            fixed (char* bptr = publicKey)
            {
                pubKey = (char*)bptr;
            }

            return ConnectSession(handle, pubKey, publicKeyLen);
        }


        [DllImport("CLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 test();

        public unsafe UInt32 GetTest()
        {
            return test();
        }

    }
}
