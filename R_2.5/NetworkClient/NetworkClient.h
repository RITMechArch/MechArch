#ifndef NETWORK_CLIENT_H_
#define NETWORK_CLIENT_H_

#include <iostream>
#include <netinet/in.h>
#include <sys/socket.h>

class NetworkClient {
    public:
        NetworkClient();
        void connectToServer( std::string hostname, const int port );
        void closeConnection();
        std::string receiveMessage();
        void sendMessage( std::string msg );
    private:
        int _sockfd;
        struct sockaddr_in _destAddr;
        char _buffer[128];
        const int _bufSize;
        bool _hasConn;
};
#endif
