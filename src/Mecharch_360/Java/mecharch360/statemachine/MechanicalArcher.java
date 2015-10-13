package mecharch360.statemachine;

import java.io.*;
import java.net.*;
import mecharch360.common.*;

public class MechanicalArcher extends Thread {
 
    // Feedback variables from arduino
    
    private InternalState state = new InternalState();
    
    // Output variables to arduino
    private short state_out;
    private short draw_out;
    private short aim_x_out;
    private short aim_y_out;
    private short trigger_out;
    
    // Utility variables
    private String hostName;
    private int arduinoPortNo;
    public boolean terminate = false;
    private int hostPortNo = 2222;
    public boolean connected = false;
    private long lastHeartBeat;
    private ServerListener host;
    private int time;
    
    // Network Variable
    private Socket arduino;
    private Socket gui;
    
    // Streams
    private PrintWriter arduinoOut = null;
    private PrintWriter guiOut = null;
    
    private BufferedReader arduinoIn = null;
    private BufferedReader guiIn = null;
    
    public MechanicalArcher(String host, int port) {
    
        int cps = 30;
        time = 1000/cps;
        
        hostName = host;
        arduinoPortNo = port;
        
        state.draw_pos = 3500;
        state.aim_x_pos = 20;
        state.aim_y_pos = 1000;
        state.f_optic = 1;
        state.r_optic = 0;
        state.aim_y_cs = 20;
        state.aim_x_r_cs = 15;
        state.aim_x_l_cs = 10;
        state.draw_cs = 25;
    
    }
    
    private void CreateClient(Socket s) {
        
        gui = s;
        try {
            guiIn = new BufferedReader(
                new InputStreamReader(gui.getInputStream()));
            guiOut = new PrintWriter(gui.getOutputStream());
        } catch (IOException ex) {
            System.out.println(ex);
        }
    }
    
    private void DisconnectClient() {
        
        try {
            if(gui != null && guiOut != null && guiIn != null) {
                guiOut.close();
                guiIn.close();
                gui.close();
                gui = null;
                guiIn = null;
                guiOut = null;
            }
        } catch (IOException ex) {
            System.out.println(ex);
        }
        
    }
    
    private void ConnectToArduino() {
        
        try {
            arduino = new Socket(hostName, arduinoPortNo);
            arduinoIn = new BufferedReader(
                new InputStreamReader(arduino.getInputStream()));
            arduinoOut = new PrintWriter(arduino.getOutputStream());
        } catch (IOException ex) {
            System.out.println(ex);
        }
        
    }
    
    private void DisconnectFromArduino() {
        
        try {
            if(arduino != null) {
                arduinoOut.close();
                arduinoIn.close();
                arduino.close();
            }
        } catch (IOException ex) {
            System.out.println(ex);
        } catch (NullPointerException ex) {
            System.out.println(ex + ": No Arduino setup");
        }
        
    }
    
    public void Exit() {
        DisconnectFromArduino();
        terminate = true;
    }
    
    private void Update() {
        try {
            if(guiIn != null && guiIn.ready()) {
                // Recieve command and deal with it
                lastHeartBeat = System.currentTimeMillis();
                String input = guiIn.readLine();

                if(input.startsWith(String.valueOf(Command.exit))) {
                    Exit();
                }
                
                // Return status of machine to the GUI
                guiOut.print(state.draw_pos-- + " " +
                            state.aim_x_pos-- + " " +
                            state.aim_y_pos++ + " " +
                            state.f_optic + " " +
                            state.r_optic + " " +
                            state.aim_y_cs + " " +
                            state.aim_x_r_cs + " " +
                            state.aim_x_l_cs + " " +
                            state.draw_cs +"\n");
                guiOut.flush();
            }
        } catch (IOException ex) {
            System.out.println(ex);
        }
        
    }
    
    public void run() {
        host = new ServerListener(hostPortNo);
        host.start();
        
        while (!terminate) {
            // Update the machine's state
            long lastTime = System.currentTimeMillis();
            
            if (lastTime - lastHeartBeat > 200 && connected) {
                DisconnectClient();
                connected = false;
            }
            
            Update();
            
            if(connected) {}
            else {
                if(host.hasClient) {
                    lastHeartBeat = System.currentTimeMillis();
                    CreateClient(host.client);
                    host.hasClient = false;
                    host.needClient = false;
                    connected = true;
                } else {
                    host.needClient = true;
                }
            }
            
            long delay = time - (System.currentTimeMillis() - lastTime);

            if (delay < 0) {
                delay = 0;
            }
            
            // Timing function
            try {
                Thread.sleep(delay);
            } catch(InterruptedException ex) {
                System.out.println(ex);
            }
        }
        host.terminate = true;
        try {
            host.join();
        } catch (InterruptedException ex) {
            System.out.println(ex);
        }
        DisconnectClient();
        
    }
    
}
