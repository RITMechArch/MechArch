#include <iostream>
#include <netdb.h>
#include <string.h>
#include <unistd.h>

#include "NetworkClient.h"


NetworkClient::NetworkClient()
    : _hasConn( false )
    , _bufSize( sizeof(_buffer) )
{
}

void NetworkClient::connectToServer( const char* const hostname, const int port )
{
    _sockfd = socket( AF_INET, SOCK_STREAM, 0 );

    struct hostent * destHostent = gethostbyname( hostname );
    if ( destHostent != NULL )
    {
        memset( &_destAddr, 0, sizeof(_destAddr) );
        _destAddr.sin_family = AF_INET;
        _destAddr.sin_port = htons( port );
        memcpy( &destHostent->h_addr, &_destAddr.sin_addr.s_addr, sizeof(destHostent->h_addr) );
        
        _hasConn = !connect( _sockfd, (sockaddr *) &_destAddr, sizeof( _destAddr ) );
        if ( !_hasConn )
        {
            std::cerr << "Failed to connect to " << hostname << std::endl;
        }
    }
    else
    {
        std::cerr << "Invalid address" << std::endl;
    }
}

void NetworkClient::closeConnection()
{
    if ( _hasConn )
    {
        close( _sockfd );
    }
}

char* NetworkClient::receiveMessage()
{
    if ( _hasConn )
    {
        // Clear both buffers before use
        memset( &_buffer, '\0', _bufSize );
        
        if ( recv( _sockfd, _buffer, _bufSize, 0 ) < 0 )
        {
            std::cerr << "There was a problem receiving a message from the server." << std::endl;
        }
    }
    char* bufCopy = new char[_bufSize];
    strcpy( bufCopy, _buffer );
    return bufCopy;
}

void NetworkClient::sendMessage( char *msg )
{
    if ( send( _sockfd, msg, strlen(msg)+1, 0 ) < 0 )
    {
        // TODO error
        std::cerr << "There was a problem receiving a message from the server." << std::endl;
    }
}

int main( int argc, char** argv )
{
    NetworkClient client = NetworkClient();
    client.connectToServer( "127.0.0.1", 2400 );
    client.sendMessage( "test message" );
    
    char * msg = client.receiveMessage();
    std::cout << msg << std::endl;
    delete msg;
    
    client.closeConnection();
}