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
        int delayMilliseconds;
        List<ActionListener> listeners = new List<ActionListener>();
        public Timer(int delayMilliseconds, ActionListener listener)
        {
            this.delayMilliseconds = delayMilliseconds;
            if (listener != null)
                listeners.Add(listener);
        }
        public void addActionListener(ActionListener listener)
        {
            listeners.Add(listener);
        }
        public void stop() => throw new NotImplementedException();
        public void start() => throw new NotImplementedException();
    }
}
