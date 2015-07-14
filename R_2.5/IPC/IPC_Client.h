#ifndef IPC_CLIENT_H_
#define IPC_CLIENT_H_

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/un.h>
#include <unistd.h>

class IPC_Client {
    private:
        const char* socketPath;
        const int socketFD;
        char receiveBuffer[100];
        socklen_t socketLength;
        struct sockaddr_un remoteAddr;
        
    public:
        IPC_Client();
        int connectToSocket();
        int closeSocket();
        int sendMessage( char* msg );
        char* receiveMessage();
};
#endif