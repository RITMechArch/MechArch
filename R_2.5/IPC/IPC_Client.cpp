#include "IPC_Client.h"

IPC_Client::IPC_Client()
    : socketFD( socket(AF_UNIX, SOCK_STREAM, 0) )
    , socketPath( ".application_socket" ) 
{}

int IPC_Client::connectToSocket()
{
    printf("Trying to connect...\n");

    remoteAddr.sun_family = AF_UNIX;
    strcpy(remoteAddr.sun_path, socketPath);
    socketLength = strlen(remoteAddr.sun_path) + sizeof(remoteAddr.sun_family);
    if (connect(socketFD, (struct sockaddr*) &remoteAddr, socketLength) == -1) {
        perror("connect");
        exit(1);
    }
    printf("Connected.\n");
}

int IPC_Client::closeSocket()
{
    close(socketFD);
}

int IPC_Client::sendMessage( char* msg )
{
    int status = send(socketFD, msg, strlen(msg), 0);
    if (status == -1) 
    {
            perror("send");
            exit(1);
    }
    return status;
}

char* IPC_Client::receiveMessage()
{
    int status=recv(socketFD, receiveBuffer, sizeof(receiveBuffer), 0);
    if (status > 0) 
    {
            receiveBuffer[status] = '\0';
    } 
    else 
    {
        if (status < 0) perror("recv");
        else printf("Server closed connection\n");
        exit(1);
    }
    return receiveBuffer;
}

int main(void)
{
    IPC_Client client = IPC_Client();
    client.connectToSocket();
    client.sendMessage("TEST");
    printf("%s\n", client.receiveMessage());
    client.closeSocket();
}