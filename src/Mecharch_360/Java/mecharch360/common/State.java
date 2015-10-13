package mecharch360.common;

public class State {
    
    // Arduino State Constants
    
    public static final short idle = 1;
    public static final short armed = 2;
    public static final short aiming = 3;
    public static final short drawing = 4;
    public static final short drawn = 5;
    public static final short retracting = 6;
    public static final short firing = 7;
    public static final short fired = 8;
    public static final short halt = 9;
    public static final short aiming_relative = 30;
    public static final short debug = 255;
}
