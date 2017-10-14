using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class FakeFrame
    {
        public void addKeyListener(KeyListener listener) => Game1.Instance.KeyListeners.Add(listener);
        public void addMouseListener(MouseListener listener) => Game1.Instance.MouseListeners.Add(listener);
        public void addMouseMotionListener(MouseMotionListener listener) => Game1.Instance.MouseMotionListeners.Add(listener);
        public void addMouseWheelListener(MouseWheelListener listener) => Game1.Instance.MouseWheelListeners.Add(listener);
        public void repaint()
        {
            //TOOD: Make this not a no-op
            
        }
        public int getWidth() => Game1.Instance.GraphicsDevice.Viewport.Width;
        public int getHeight() => Game1.Instance.GraphicsDevice.Viewport.Height;

    }
}
