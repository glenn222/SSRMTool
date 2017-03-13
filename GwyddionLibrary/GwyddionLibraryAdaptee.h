__declspec(dllexport) unsigned long ConnectSession(unsigned long handle,
	unsigned char * publicKey,
	unsigned char   publicKeyLen);
__declspec(dllexport) unsigned long TestSession(unsigned long handle,
	unsigned char * publicKey,
	unsigned char   publicKeyLen);
__declspec(dllexport) unsigned int TestGwyddion(unsigned long handle,
	unsigned char * publicKey,
	unsigned char   publicKeyLen);