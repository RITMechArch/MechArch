#include <SPI.h>
#include <Ethernet.h>
#include <String.h> 
// network configuration.  
// gateway and subnet are optional.

 // the media access control (ethernet hardware) address for the shield:
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };  

//the IP address for the shield:
byte ip[] = { 169, 254, 211, 1 };    

// the router's gateway address:
byte gateway[] = { 129, 21, 249, 254 };

// the subnet:
byte subnet[] = { 255, 255, 255, 0 };

// telnet defaults to port 23
EthernetServer server = EthernetServer(23);
//declare the client
EthernetClient client = server.available();

void setup()
{
  // initialize the ethernet device
  Ethernet.begin(mac, ip, gateway, subnet);

  // start listening for clients
  server.begin();
  Serial.begin(9600);
  
  
}
int parseNum(char intpart[7])
{
  int num = 0;
  num = (intpart[3] - '0') * 1000;
  num = num + (intpart[4] - '0') * 100;
  num = num + (intpart[5] - '0') * 10;
  num = num + (intpart[6] - '0');
  return num;
}
void transmitArray(char fullArray[7])
{
  char s;
  int num;
  for (int i = 0; i < 3; i++)
    {
      s = fullArray[i];
      client.print(s);
    }
    
   //turn the character numbers into one number
   num = parseNum(fullArray);
   client.print(num);
}
void loop()
{
  // if an incoming client connects, there will be bytes available to read:
  char c;
  

  char transmit_Xpos[7];
  char transmit_Ypos[7];
  char transmit_state[7];
  char transmit_OF[7];
  char transmit_OR[7];
  
  transmit_Xpos[0] = 'X';
  transmit_Xpos[1] = 'N';
  transmit_Xpos[2] = '0';
  
  transmit_Ypos[0] = 'Y';
  transmit_Ypos[1] = 'N';
  transmit_Ypos[2] = '0';
  
  transmit_state[0] = 'S';
  transmit_state[1] = 'T';
  transmit_state[2] = 'N';
  transmit_state[3] = '0';
  transmit_state[4] = '0';
  transmit_state[5] = '0';
  
  transmit_OF[0] = 'O';
  transmit_OF[1] = 'F';
  transmit_OF[2] = '0';
  transmit_OF[3] = '0';
  transmit_OF[4] = '0';
  transmit_OF[5] = '0';
  
  transmit_OR[0] = 'O';
  transmit_OR[1] = 'R';
  transmit_OF[2] = '0';
  transmit_OF[3] = '0';
  transmit_OF[4] = '0';
  transmit_OF[5] = '0';

  
  char incoming[100];
  
  if (client) {
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
    
    //output the contents of the transmit array
    //Add variable to array
    int Xpos = 365;
    int Ypos = 1234;
    int State = 5;
    int Or = 0;
    int Of = 1; 
    int len = 0;
    String str;
    char cstr[7];
    str = String(Xpos);
    str.toCharArray(cstr,7); 
    
     //print arrays
     transmitArray(transmit_Xpos);
     transmitArray(transmit_Ypos);
     transmitArray(transmit_state);
     transmitArray(transmit_OF);
     transmitArray(transmit_OR);
     
   
  }
}
