using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechArcher
{
    class CommuncationControl
    {
        private static CommuncationControl instance;

        private CommuncationControl()
        {
        }

        public CommuncationControl getInstance()
        {
            if (instance != null)
                instance = new CommuncationControl();
            return instance;
        }


        public bool sendFire()
        {
            return false;
        }

        public bool sendDraw()
        {
            return false;
        }

        public bool sendESTOP()
        {
            return false;
        }

        public bool sendRetract()
        {
            return false;
        }

        public string setLCD(string message)
        {
            return message;
        }
    }
}
