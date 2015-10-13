package mecharch360.statemachine;

public class MechArchState {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        final int arduinoPortNo = 2300;
        final String arduinoIP = "192.168.1.177";
        
        MechanicalArcher machine = new MechanicalArcher(arduinoIP, arduinoPortNo);
        machine.start();
    }
    
}
