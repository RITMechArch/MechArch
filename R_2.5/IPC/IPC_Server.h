#ifndef IPC_SERVER_H_
#define IPC_SERVER_H_

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/un.h>
#include <unistd.h>

#define SOCK_PATH ".application_socket"

class IPC_Server
{
    private:
        const char* socketPath;
        const int localSocketFD;
        int remoteSocketFD;
        struct sockaddr_un localAddr, remoteAddr;
        socklen_t localLen, remoteLen;
        char receiveBuffer[100];

    public:
        IPC_Server();
        int connectToSocket();
        int closeSocket();
        int sendMessage( char* msg );
        char* receiveMessage();
};
#endif
