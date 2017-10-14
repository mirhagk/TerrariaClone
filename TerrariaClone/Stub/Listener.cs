using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class KeyEvent
    {
        public byte VK_LEFT { get; internal set; }
        public byte VK_A { get; internal set; }
        public byte VK_RIGHT { get; internal set; }
        public byte VK_D { get; internal set; }
        public byte VK_W { get; internal set; }
        public byte VK_UP { get; internal set; }
        public byte VK_DOWN { get; internal set; }
        public byte VK_S { get; internal set; }
        public byte VK_SHIFT { get; internal set; }
        public byte VK_ESCAPE { get; internal set; }
        public byte VK_1 { get; internal set; }
        public byte VK_2 { get; internal set; }
        public byte VK_3 { get; internal set; }
        public byte VK_4 { get; internal set; }
        public byte VK_5 { get; internal set; }
        public byte VK_6 { get; internal set; }
        public byte VK_7 { get; internal set; }
        public byte VK_8 { get; internal set; }
        public byte VK_9 { get; internal set; }
        public byte VK_0 { get; internal set; }
        public byte VK_Q { get; internal set; }
        public byte VK_E { get; internal set; }
        public byte VK_R { get; internal set; }
        public byte VK_T { get; internal set; }
        public byte VK_Y { get; internal set; }
        public byte VK_U { get; internal set; }
        public byte VK_I { get; internal set; }
        public byte VK_O { get; internal set; }
        public byte VK_P { get; internal set; }
        public byte VK_F { get; internal set; }
        public byte VK_G { get; internal set; }
        public byte VK_H { get; internal set; }
        public byte VK_J { get; internal set; }
        public byte VK_K { get; internal set; }
        public byte VK_L { get; internal set; }
        public byte VK_Z { get; internal set; }
        public byte VK_X { get; internal set; }
        public byte VK_C { get; internal set; }
        public byte VK_V { get; internal set; }
        public byte VK_B { get; internal set; }
        public byte VK_N { get; internal set; }
        public byte VK_M { get; internal set; }
        public byte VK_SPACE { get; internal set; }
        public byte VK_MINUS { get; internal set; }
        public byte VK_EQUALS { get; internal set; }
        public byte VK_OPEN_BRACKET { get; internal set; }
        public byte VK_CLOSE_BRACKET { get; internal set; }
        public byte VK_BACK_SLASH { get; internal set; }
        public byte VK_COLON { get; internal set; }
        public byte VK_QUOTE { get; internal set; }
        public byte VK_COMMA { get; internal set; }
        public byte VK_PERIOD { get; internal set; }
        public byte VK_SLASH { get; internal set; }

        public byte getKeyCode() => throw new NotImplementedException();
    }
    public class MouseEvent
    {
        public object getButton() => throw new NotImplementedException();
        public static object BUTTON1 => throw new NotImplementedException();
        public static object BUTTON3 => throw new NotImplementedException();

        internal int getX()
        {
            throw new NotImplementedException();
        }

        internal int getY()
        {
            throw new NotImplementedException();
        }
    }
    public class ChangeEvent { }
    public class MouseWheelEvent { }
    public interface ChangeListener { }
    public interface KeyListener { }
    public interface MouseListener { }
    public interface MouseMotionListener { }
    public interface MouseWheelListener { }
}
