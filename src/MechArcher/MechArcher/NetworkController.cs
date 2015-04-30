using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MechArcher
{
    class NetworkController
    {
        private MachineStatus status;
        private TcpClient connection = null;
        private NetworkStream ns = null;

        private static string estopCommand = "e~";

        private static string drawCommand = "d~";
        private static string fireCommand = "f~";
        private static string getStatusCommand = "g~";
        private static string retractCommand = "r~";

        public NetworkController(MachineStatus initialStatus)
        {
            status = initialStatus;
            connection = new TcpClient("169.254.211.1", 23);
            ns = connection.GetStream();
            updateMachineStatus();
        }


        public void eStop()
        {
            ns.Write(Encoding.ASCII.GetBytes(estopCommand), 0, estopCommand.Length);
            ns.Flush();

        }

        public void draw()
        {
            ns.Write(Encoding.ASCII.GetBytes(drawCommand), 0, estopCommand.Length);
            ns.Flush();
        }

        public void fire()
        {
            ns.Write(Encoding.ASCII.GetBytes(fireCommand), 0, estopCommand.Length);
            ns.Flush();
        }

        public void retract()
        {
            ns.Write(Encoding.ASCII.GetBytes(retractCommand), 0, estopCommand.Length);
            ns.Flush();
        }


        public void aimX(int target)
        {
            if (target < 4096 && target > -4096)
            {
                string command = "x" + target + "~";
                ns.Write(Encoding.ASCII.GetBytes(command), 0, command.Length);
                ns.Flush();
            }
        }
        public void aimY(int target)
        {
            if (target < 4096 && target >= 0)
            {
                string command = "y" + target.ToString() + "~";
                ns.Write(Encoding.ASCII.GetBytes(command), 0, command.Length);
                ns.Flush();
            }
        }

        public void updateMachineStatus()
        {
            ns.Write(Encoding.ASCII.GetBytes(getStatusCommand), 0, getStatusCommand.Length);
            ns.Flush();

            byte[] data = new byte[256];
            int recv = ns.Read(data, 0, data.Length);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            string[] attributes = stringData.Split('_');

            // We override the machine's state without a validity check because the machine is holding the true state.
            // If the machine advances in state twice between updates, validation on this side will fail, so we use
            // the machine's reported value.
            MachineStatus.States state = (MachineStatus.States)Enum.Parse(typeof(MachineStatus.States), attributes[0]);
            status.setCurrentState(state);

            // We invert the arduino's optic sensor logic here - if arduino returned 0, the sensor is occluded 
            // and an arrow is present.
            status.setFOptic(attributes[1] == "0");
            status.setROptic(attributes[2] == "0");

            status.setMoving(attributes[3] != "0");

            status.setXPosition(int.Parse(attributes[4]));
            status.setYPosition(int.Parse(attributes[5]));

            Console.WriteLine(stringData);
        }
    }
}
