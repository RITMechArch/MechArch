package mecharch360.common;

public class InternalState {
    
    public short state;
    public short draw_pos;
    public short aim_x_pos;
    public short aim_y_pos;
    public byte f_optic;
    public byte r_optic;
    public short aim_y_cs;
    public short aim_x_r_cs;
    public short aim_x_l_cs;
    public short draw_cs;
    
    
    public InternalState() {
        state = 0;
        draw_pos = 0;
        aim_x_pos = 0;
        aim_y_pos = 0;
        f_optic = 0;
        r_optic = 0;
        aim_y_cs = 0;
        aim_x_r_cs = 0;
        aim_x_l_cs = 0;
        draw_cs = 0;
    }
}
