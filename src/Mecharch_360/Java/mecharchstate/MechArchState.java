package mecharchstate;

import java.io.*;
import java.net.*;

public class MechArchState {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
        final int hostPortNo = 2222;
        final int arduinoPortNo = 2300;
        final String arduinoIP = "192.168.1.177";
        
        ServerSocket serverSocket = null;
        Socket clientSocket = null;
        
        MechanicalArcher machine = new MechanicalArcher(arduinoIP, arduinoPortNo);
        machine.start();
        System.out.println("Opening server on port 2222...");
        try {
            serverSocket = new ServerSocket(hostPortNo);
        } catch (IOException ex) {
            System.out.println(ex);
            machine.Exit();
            System.exit(1);
        }
        System.out.println("Server open. Listening for clients...");
        while(!machine.terminate) {
            try {
                clientSocket = null;
                clientSocket = serverSocket.accept();
            } catch(IOException ex) {
                System.out.println(ex);
            }

            if (clientSocket != null) {
                machine.CreateClient(clientSocket);
            } else {
                System.out.println("Error: Failed to create client socket!");
                machine.Exit();
                System.exit(1);
            }
        }
        System.out.println("State machine has ended. Tidying up resources...");
        try {
            //machine.join();
            serverSocket.close();
        } catch (IOException ex) {
            System.out.println(ex);
        }
        System.out.println("Exiting...");
    }
    
}
