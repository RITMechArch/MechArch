#include "Winsock_Ethernet.h"

Ethernet_Client::Ethernet_Client() {}

bool Ethernet_Client::ConnectToHost(int PortNo, char* IPAddress) {

	// Start up Winsock
	WSAData wsadata;

	int error = WSAStartup(0x0202, &wsadata);

	// Check for errors
	if (error)
		return false;

	// Did we get the right version of Winsock?
	if (wsadata.wVersion != 0x0202) {
		WSACleanup(); // Clean up Winsock
		return false;
	}

	// Fill out the information needed to initialize a socket
	SOCKADDR_IN target;  // Socket address information

	target.sin_family = AF_INET;			// address family Internet
	target.sin_port = htons(PortNo);		// Port to connect on
	target.sin_addr.s_addr = inet_addr(IPAddress);	// Target IP

	s = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);	// Create socket
	if (s == INVALID_SOCKET) {
		return false;  // Couldn't create the socket
	}

	// Try connecting

	if (connect(s, (SOCKADDR *)&target, sizeof(target)) == SOCKET_ERROR) {
		return false; // Couldn't connect
	}
	else
		return (connected = true);  // Success
}

void Ethernet_Client::CloseConnection() {

	if (s)
		closesocket(s);

	WSACleanup();
	connected = false;

}

int Ethernet_Client::SendData(char * buffer, int size) {

	return send(s, buffer, size, 0);

}

int Ethernet_Client::RecieveData(char * buffer, int maxSize) {

	return recv(s, buffer, maxSize, 0);

}

bool Ethernet_Client::IsConnected() {
	return connected;
}