#ifndef ETHERNET_CLIENT_H
#define ETHERNET_CLIENT_H

#include <winsock.h>

#pragma comment (lib, "Ws2_32.lib")

class Ethernet_Client {

	SOCKET s;
	bool connected = false;

public:

	Ethernet_Client();

	bool ConnectToHost(int, char*);
	bool IsConnected();
	void CloseConnection();

	int SendData(char *, int);
	int RecieveData(char *, int);

};


#endif /*ETHERNET_CLIENT_H*/