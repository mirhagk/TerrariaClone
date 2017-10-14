using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    class ActionEvent
    {
    }
    delegate void ActionListener(ActionEvent actionEvent);
    class Timer
    {
        System.Timers.Timer internalTimer;
        int delayMilliseconds;
        List<ActionListener> listeners = new List<ActionListener>();
        public Timer(int delayMilliseconds, ActionListener listener)
        {
            this.delayMilliseconds = delayMilliseconds;
            internalTimer = new System.Timers.Timer(this.delayMilliseconds);
            internalTimer.Elapsed += InternalTimer_Elapsed;
            if (listener != null)
                listeners.Add(listener);
        }

        private void InternalTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var actionListener in listeners)
                actionListener(null);
        }

        public void addActionListener(ActionListener listener)
        {
            listeners.Add(listener);
        }
        public void stop() => internalTimer.Stop();
        public void start() => internalTimer.Start();
    }
}
