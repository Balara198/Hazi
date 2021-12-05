using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    class ControlPanel : Subject
    {
        private bool simaRiasztoAktiv = false;
        private bool tuzjelzoRiasztoAktiv = false;

        private List<DateTime> simaRiasztoLog;
        private List<DateTime> tuzjelzoRiasztoLog;

        public bool getSimaRiasztoAktiv()
        {
            return simaRiasztoAktiv;
        }

        public bool getTuzjelzoRiasztoAktiv()
        {
            return tuzjelzoRiasztoAktiv;
        }

        public void riaszt(string opcio)
        {
            switch (opcio)
            {
                case "sima":
                    break;
                case "tuz":
                    break;
                case "isis":
                    break;
                default:
                    break;
            }
        }

    }
}
