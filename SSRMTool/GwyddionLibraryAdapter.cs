using System;
using System.Runtime.InteropServices;

namespace SSRMTool
{
    public class GwyddionLibraryAdapter
    {
        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 ConnectSession(UInt32 handle, char* publicKey, char publicKeyLen);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 TestGwyddion();

        // Example Method
        public unsafe UInt32 GetConnectSession(UInt32 handle, string publicKey, char publicKeyLen)
        {
            //"Convert" string to char*
            char* pubKey;
            fixed (char* bptr = publicKey)
            {
                pubKey = (char*)bptr;
            }

            return ConnectSession(handle, pubKey, publicKeyLen);
        }

        //TODO: Implement wrapper methods to call in GwyddionLibraryAdaptee.c
        public unsafe UInt32 TestGwyddionSession()
        {
            return TestGwyddion();
        }

    }
}
