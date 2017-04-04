//__declspec(dllexport) unsigned long ConnectSession(unsigned long handle,
	//unsigned char * publicKey,
	//unsigned char   publicKeyLen);
__declspec(dllexport) bool WriteGWYFile(char *path, double *newimagedata,unsigned int xres, unsigned int yres, double xreal, double yreal, char *units);
__declspec(dllexport) bool WriteGWYChannel(char* path, double *newimagedata, unsigned int xres, unsigned int yres, double xreal, double yreal, char *units);
__declspec(dllexport) double* CreateArray(int length);
__declspec(dllexport) bool DestroyArray(double *used_array);
__declspec(dllexport) double* ReadGWYChannelData(char* path, int id, int *xres, int *yres, double *xreal, double *yreal);
__declspec(dllexport) int* ReadGWYChannelNames(char* path,int* n);

