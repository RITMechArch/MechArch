#include "IPC_Server.h"

IPC_Server::IPC_Server()
    : socketPath( ".application_socket" )
    , localSocketFD( socket(AF_UNIX, SOCK_STREAM, 0) )
{}

int IPC_Server::connectToSocket()
{
    localAddr.sun_family = AF_UNIX;
    strcpy(localAddr.sun_path, socketPath);
    localLen = strlen(localAddr.sun_path) + sizeof(localAddr.sun_family);
    
    if (bind(localSocketFD, (struct sockaddr *) &localAddr, localLen) == -1) {
        perror("bind");
        exit(1);
    }

    if (listen(localSocketFD, 1) == -1) {
        perror("listen");
        exit(1);
    }
    
    printf("Waiting for a connection...\n");
    remoteLen = sizeof(remoteAddr);
    if ((remoteSocketFD = accept(localSocketFD, (struct sockaddr *) &remoteAddr, &remoteLen)) == -1) {
	perror("accept");
	exit(1);
    }
    printf("Connected.\n");
}

int IPC_Server::closeSocket()
{
    close( localSocketFD );
    close( remoteSocketFD );
}

int IPC_Server::sendMessage( char* msg )
{
    if (send(remoteSocketFD, msg, strlen(msg), 0) < 0) 
    {
	perror("send");
    }
}



char* IPC_Server::receiveMessage()
{
    memset( receiveBuffer, '\0', sizeof(receiveBuffer) );
    int status = recv( remoteSocketFD, receiveBuffer, 100, 0 );
    if (status < 0)
    {
        perror("recv");
    }
    return receiveBuffer;
}

int main(void)
{
    IPC_Server server = IPC_Server();
    server.connectToSocket();
    char* msg = server.receiveMessage();
    printf("%s\n", msg);
    server.sendMessage(msg);
    server.closeSocket();
}
