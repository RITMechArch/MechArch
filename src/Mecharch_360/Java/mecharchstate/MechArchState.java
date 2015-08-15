package mecharchstate;

import java.io.*;
import java.net.*;

public class MechArchState {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int portNumber = 2222;
        System.out.println("Listening on port "+ portNumber + "...");
        try (
            ServerSocket serverSocket = new ServerSocket(portNumber);
            Socket clientSocket = serverSocket.accept();
            PrintWriter out = 
                    new PrintWriter(clientSocket.getOutputStream(), true);
            BufferedReader in = 
                    new BufferedReader(
                    new InputStreamReader(clientSocket.getInputStream()));
        ) {
            System.out.println("Connection Established.");
            while(true) {
                if (in.ready()) {
                    System.out.println(in.readLine());
                }
            }
            
        } catch (IOException e) {
            
            
        }
    }
    
}
