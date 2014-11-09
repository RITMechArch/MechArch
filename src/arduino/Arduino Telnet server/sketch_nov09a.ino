#include <SPI.h>
#include <Ethernet.h>

// network configuration.  
// gateway and subnet are optional.

 // the media access control (ethernet hardware) address for the shield:
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };  

//the IP address for the shield:
byte ip[] = { 169, 254, 176, 1 };    

// the router's gateway address:
byte gateway[] = { 129, 21, 249, 254 };

// the subnet:
byte subnet[] = { 255, 255, 255, 0 };

// telnet defaults to port 23
EthernetServer server = EthernetServer(23);

void setup()
{
  // initialize the ethernet device
  Ethernet.begin(mac, ip, gateway, subnet);

  // start listening for clients
  server.begin();
  Serial.begin(9600);
  
}

void loop()
{
  // if an incoming client connects, there will be bytes available to read:
  char c; 
  char incoming[100];
  EthernetClient client = server.available();
  if (client == true) {
    // read bytes from the incoming client and write them back
    // to any clients connected to the server:
    int ii = 0;

    while ((c = client.read()) != '\n') 
    {
      incoming[ii++] = c;
      Serial.println(c);
    }
    // the variable incoming[] now contains the most recent value sent
    // so you can do something with it  
  }
}
