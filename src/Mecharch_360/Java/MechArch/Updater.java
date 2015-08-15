/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MechArch;

/**
 *
 * @author Alex
 */
public class Updater implements Runnable {
    
    private MechArchGUI MechArch;
    private int delay;
    
    public Updater(MechArchGUI gui, int cps) {
    
        MechArch = gui;
        delay = 1000/cps;
    }
    
    public void run() {
    
        while(!MechArch.terminateThread) {
            MechArch.Update();
            try {
                Thread.sleep(delay);
            } catch (InterruptedException ex) {}
        
        }
    }
    
}
