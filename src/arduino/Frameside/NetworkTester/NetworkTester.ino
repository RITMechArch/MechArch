#include <SPI.h>
#include <Ethernet.h>

//-------- STATE const declarations -------------
const int STATE_IDLE        = 1;
const int STATE_ARMED       = 2;
const int STATE_AIMING      = 3;
const int STATE_DRAWING     = 4;
const int STATE_DRAWN       = 5;
const int STATE_RETRACTING  = 6;
const int STATE_FIRING      = 7;
const int STATE_FIRED       = 8;
const int STATE_HALT        = 9;



byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };  
byte ip[] = { 169, 254, 211, 1 };    
byte gateway[] = { 129, 21, 249, 254 };
byte subnet[] = { 255, 255, 255, 0 };

char buf[128];
int bufferSize = 0;

EthernetServer server = EthernetServer(23);

int currentState = STATE_IDLE;
EthernetClient client;
boolean hasConnected = false;

void setup() {
  // put your setup code here, to run once:
  pinMode(4, OUTPUT);
  digitalWrite(4, HIGH);
  pinMode(10, OUTPUT);
  pinMode(53, OUTPUT);
  
  Serial.begin(9600);
  
  Ethernet.begin(mac, ip, gateway, subnet);
  Serial.println(Ethernet.localIP());
}

void loop() {
  // put your main code here, to run repeatedly:
  
}

void parseEthernetBuffer()
{
  if (bufferSize > 0)
  {
      char first = (char) buf[0];
      switch(first)
      {
          case'g':
          case 'G':
          {
              String ret = digitalRead(fOptic);
              break;
          }
      }
  }
}

void clearEthernetBuffer()
{
    for(int i = 0; i < bufferSize; i++)
    {
        buf[i] = 0;
    }
    bufferSize = 0;
}
