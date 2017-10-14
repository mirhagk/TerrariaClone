using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class FakeFrame
    {
        public void addKeyListener(KeyListener listener) => throw new NotImplementedException();
        public void addMouseListener(MouseListener listener) => throw new NotImplementedException();
        public void addMouseMotionListener(MouseMotionListener listener) => throw new NotImplementedException();
        public void addMouseWheelListener(MouseWheelListener listener) => throw new NotImplementedException();
        public void repaint() => throw new NotImplementedException();
        public int getWidth() => 1920;//TODO: Make work
        public int getHeight() => 1080;//TODO: Make work

    }
}
