using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MechArcher
{
    class NetworkController
    {
        private static const IPAddress serverAddress = IPAddress.Parse("169.254.211.1");
        private TcpListener serverListener = new TcpListener(serverAddress,23);
        Socket connection = null;

        public NetworkController()
        {
            serverListener.Start();
            connection = serverListener.AcceptSocket();
            Console.WriteLine(connection.RemoteEndPoint);
        }


        public void eStop();
        public void draw();
        public void retract();
        public void fire();
        public void aimX();
        public void aimY();

        static void main()
        {
            Console.WriteLine("Starting");
        }
    }
}
