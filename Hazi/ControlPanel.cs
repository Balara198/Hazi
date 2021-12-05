using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    class ControlPanel
    {
        private bool simpleAlarmActive = false;
        private bool fireAlarmActive = false;

        private List<object> simpleAlarmHandlers;
        private List<object> fireAlarmHandlers;

        private List<DateTime> simpleAlarmLog;
        private List<DateTime> fireAlarmLog;

        public void activateSimpleAlarm()
        {
            foreach (object handler in simpleAlarmHandlers)
            {
                handler.activate()
            }
        }
    }
}
