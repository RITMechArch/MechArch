#include <SPI.h>
#include <Ethernet.h>

// Randomized valid MAC Address. 
// Can't match the MAC address of the laptop's NIC
byte mac[] = { 0x31, 0xC0, 0x0E, 0xC8, 0x0A, 0xE6 };
IPAddress ip(192,168,1, 177);
IPAddress gateway(192,168,1, 1);
IPAddress subnet(255, 255, 0, 0);


// Use non-standard port 9999
EthernetServer server(9999);

void setup() {
  // initialize the ethernet device
  Ethernet.begin(mac, ip, gateway, subnet);
  // start listening for clients
  server.begin();
 // Open serial communications and wait for port to open:
  Serial.begin(9600);

  Serial.print("Server address:");
  Serial.println(Ethernet.localIP());
}

void loop() {
  // wait for a new client:
  EthernetClient client = server.available();

  // Make sure a valid client is connected
  if (client) {
    // TODO authenticate the new client
    
    // Maintain the connection until the client disconnects
    while (true) {
      
      // Get the next message from the client if there is one
      if (client.available() > 0) 
      {
          // read the bytes incoming from the client:
          char thisChar = client.read();
        
          // echo the bytes back to the client:
          server.write(thisChar);
        
          // echo the bytes to the server as well:
          Serial.write(thisChar);
      } // End message read
      
      
      // Write a message to the client
      // TODO construct and send a bit stream representing
      //     the machine's state
      
      
      // Close the connection if the client is no longer connected
      if ( !client.connected() ) {
        client.stop();
        break;
      }
      
    }
  }
}
