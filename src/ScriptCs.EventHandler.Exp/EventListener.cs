using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ScriptCs.EventManager.Exp
{
    public class EventListener
    {
        public void Subscribe(MySystemEvents powerModeChanged, Func<object, EventArgs, Task> handler)
        {
            switch (powerModeChanged)
            { 
                case MySystemEvents.PowerModeChanged:
                    Microsoft.Win32.SystemEvents.PowerModeChanged += (s, e) => handler(s, e);
                    // TODO: remember to unsubscribe
                    return;
                default:
                    return;
            }
        }
    }
}
