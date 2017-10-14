using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TerrariaClone
{
    public class ActionEvent
    {
    }
    public delegate void ActionListener(ActionEvent actionEvent);
    public class Timer
    {
        public static List<Timer> TimerList = new List<Timer>();
        int delayMilliseconds;
        int elapsedMilliseconds;
        bool running = true;
        List<ActionListener> listeners = new List<ActionListener>();
        public Timer(int delayMilliseconds, ActionListener listener)
        {
            this.delayMilliseconds = delayMilliseconds;
            if (listener != null)
                listeners.Add(listener);
            TimerList.Add(this);
        }

        public void Tick(int milliseconds)
        {
            if (!running) return;
            elapsedMilliseconds += milliseconds;
            while (elapsedMilliseconds > delayMilliseconds)
            {
                foreach (var actionListener in listeners)
                    actionListener(null);
                elapsedMilliseconds -= delayMilliseconds;
            }
        }

        public void addActionListener(ActionListener listener)
        {
            listeners.Add(listener);
        }
        public void stop()
        {
            elapsedMilliseconds = 0;
            running = false;
        }
        public void start() => running = true;
    }
}
