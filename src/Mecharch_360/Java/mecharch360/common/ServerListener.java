package mecharch360.common;

import java.io.*;
import java.net.*;

public class ServerListener extends Thread{
    
    int portNo;
    public Socket client;
    //public boolean alive;
    public boolean hasClient;
    public boolean terminate;
    public boolean needClient;
    
    public ServerListener(int port) {
        hasClient = false;
        portNo = port;
        client = null;
    }
    
    public void run() {

        ServerSocket serverSocket = null;
        while(!terminate) {
            if(needClient && !hasClient) {
                try {
                    serverSocket = new ServerSocket(portNo);
                } catch (IOException ex) {
                    System.out.println(ex);
                } 

                if(serverSocket == null) {
                    return;
                }

                try {
                    client = serverSocket.accept();
                    serverSocket.close();
                } catch (IOException ex) {
                    System.out.println(ex);
                }
                hasClient = true;
            } else {
                try {
                    Thread.sleep(30);
                } catch (InterruptedException ex) {
                    System.out.println(ex);
                }
            }
        }
        
        
    }
    
}
