using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.EventManager.Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            var em = new EventListener();
            em.Subscribe(MySystemEvents.PowerModeChanged, (s, ea) =>
            {
                var e = ea as Microsoft.Win32.PowerModeChangedEventArgs;
                if (e.Mode == PowerModes.Resume)
                {
                    Console.WriteLine("Resumed! Haha.");
                    return Task.FromResult(true);
                }
                else
                {
                    Console.WriteLine(e.Mode.ToString());
                    return Task.FromResult(false);
                }
            });

            Console.WriteLine("Let's see what happens when you put the computer to sleep!");
            Console.ReadLine();
        }
    }
}
