using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    public abstract class AlarmBase
    {
        private List<string> alarmMessage;
        private ConsoleColor messageColor;
        private int alarmDuration;
    }
}
