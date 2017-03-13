using System;
using System.Runtime.InteropServices;

namespace SSRMTool
{
    public class GwyddionLibraryAdapter
    {
        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 ConnectSession(UInt32 handle, char* publicKey, char publicKeyLen);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 TestSession(UInt32 handle, char* publicKey, char publicKeyLen);

        [DllImport("GwyddionLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern UInt32 TestGwyddion(UInt32 handle, char* publicKey, char publicKeyLen);

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

        public unsafe UInt32 TestGwyddionSession(UInt32 handle, string publicKey, char publicKeyLen)
        {
            //"Convert" string to char*
            char* pubKey;
            fixed (char* bptr = publicKey)
            {
                pubKey = (char*)bptr;
            }

            return TestGwyddion(handle, pubKey, publicKeyLen);
        }

    }
}
