/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mecharch360.GUI;

/**
 *
 * @author Alex
 */
public class Updater extends Thread {
    
    private MechArchGUI MechArch;
    private int time;
    
    public Updater(MechArchGUI gui) {
    
        int cps = 20;
        MechArch = gui;
        time = 1000/cps;

    }
    
    public void run() {
        
        while(!MechArch.terminateThread) {
            
            long lastTime = System.currentTimeMillis();
            
            MechArch.Update();
            
            long delay = time - (System.currentTimeMillis() - lastTime);
            
            if(delay < 0) {
                delay = 0;
            }
            
            try {
                Thread.sleep(delay);
            } catch (InterruptedException ex) {
                System.out.println(ex);
            }
        
        }
    }
    
}
