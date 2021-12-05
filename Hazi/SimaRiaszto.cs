using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    class SimaRiaszto : Subject
    {
        private int duration = 7;
        private int ticksLeft = 0;
        private ConsoleColor msgColor = ConsoleColor.Blue;
        private string[] msg = new string[] {"Normál riasztás", ""};
        public bool aktiv;

        public SimaRiaszto()
        {
            Update();
        }

        public void Update()
        {
            this.aktiv = ControlPanel
        }
    }
}
