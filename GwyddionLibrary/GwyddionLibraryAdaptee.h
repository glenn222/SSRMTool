//__declspec(dllexport) unsigned long ConnectSession(unsigned long handle,
	//unsigned char * publicKey,
	//unsigned char   publicKeyLen);
__declspec(dllexport) bool WriteGWY(double *newimagedata,unsigned int xres, unsigned int yres);
__declspec(dllexport) bool WriteGWYChannel(char* path, double *newimagedata, unsigned int xres, unsigned int yres);
__declspec(dllexport) double* CreateArray(int length);
__declspec(dllexport) bool DestroyArray(double *used_array);
__declspec(dllexport) double* ReadGWYChannelData(char* path,int id,int *resX,int *resY);
__declspec(dllexport) int* ReadGWYChannelNames(char* path,int* n);

