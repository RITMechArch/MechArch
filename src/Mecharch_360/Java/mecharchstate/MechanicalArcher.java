package mecharchstate;

import java.io.*;
import java.net.*;

public class MechanicalArcher extends Thread {
 
    // Feedback variables from arduino
    private short state;
    private short draw_pos;
    private short aim_x_pos;
    private short aim_y_pos;
    private byte f_optic;
    private byte r_optic;
    private short aim_y_cs;
    private short aim_x_r_cs;
    private short aim_x_l_cs;
    private short draw_cs;
    
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
        
        draw_pos = 3500;
        aim_x_pos = 20;
        aim_y_pos = 1000;
        f_optic = 1;
        r_optic = 0;
        aim_y_cs = 20;
        aim_x_r_cs = 15;
        aim_x_l_cs = 10;
        draw_cs = 25;
    
    }
    
    public void CreateClient(Socket s) {
        
        gui = s;
        try {
            guiIn = new BufferedReader(
                new InputStreamReader(gui.getInputStream()));
            guiOut = new PrintWriter(gui.getOutputStream());
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
                String input = guiIn.readLine();
                //System.out.println(input);
                if(input.startsWith(String.valueOf(command_exit))) {
                    Exit();
                }
                
                // Return status of machine to the GUI
                guiOut.print(draw_pos-- + " " +
                            aim_x_pos-- + " " +
                            aim_y_pos++ + " " +
                            f_optic + " " +
                            r_optic + " " +
                            aim_y_cs + " " +
                            aim_x_r_cs + " " +
                            aim_x_l_cs + " " +
                            draw_cs +"\n");
                guiOut.flush();
            }
        } catch (IOException ex) {
            System.out.println(ex);
        }
        
    }
    
    public void run() {
        
        while (!terminate) {
            // Update the machine's state
            long lastTime = System.currentTimeMillis();
            
            Update();
            
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
    }
    
    // GUI Command Constants
    
    static final short command_no_action = 0;
    static final short command_connect_arduino = 1;
    static final short command_disconnect_arduino = 2;
    static final short command_exit = 3;
    static final short command_draw = 4;
    static final short command_retract = 5;
    static final short command_fire = 6;
    static final short command_estop = 7;
    
    // Arduino State Constants
    
    static final short state_idle = 1;
    static final short state_armed = 2;
    static final short state_aiming = 3;
    static final short state_drawing = 4;
    static final short state_drawn = 5;
    static final short state_retracting = 6;
    static final short state_firing = 7;
    static final short state_fired = 8;
    static final short state_halt = 9;
    static final short state_aiming_relative = 30;
    static final short state_debug = 255;
}
