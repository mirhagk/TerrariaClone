using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class KeyEvent
    {
        static byte Code(Keys key) => (byte)(int)key;
        public byte VK_LEFT { get; } = Code(Keys.Left);
        public byte VK_A { get; } = Code(Keys.A);
        public byte VK_RIGHT { get; } = Code(Keys.Right);
        public byte VK_D { get; } = Code(Keys.D);
        public byte VK_W { get; } = Code(Keys.W);
        public byte VK_UP { get; } = Code(Keys.Up);
        public byte VK_DOWN { get; } = Code(Keys.Down);
        public byte VK_S { get; } = Code(Keys.S);
        public byte VK_SHIFT { get; } = Code(Keys.LeftShift);
        public byte VK_ESCAPE { get; } = Code(Keys.Escape);
        public byte VK_1 { get; } = Code(Keys.NumPad1);
        public byte VK_2 { get; } = Code(Keys.NumPad2);
        public byte VK_3 { get; } = Code(Keys.NumPad3);
        public byte VK_4 { get; } = Code(Keys.NumPad4);
        public byte VK_5 { get; } = Code(Keys.NumPad5);
        public byte VK_6 { get; } = Code(Keys.NumPad6);
        public byte VK_7 { get; } = Code(Keys.NumPad7);
        public byte VK_8 { get; } = Code(Keys.NumPad8);
        public byte VK_9 { get; } = Code(Keys.NumPad9);
        public byte VK_0 { get; } = Code(Keys.NumPad0);
        public byte VK_Q { get; } = Code(Keys.Q);
        public byte VK_E { get; } = Code(Keys.E);
        public byte VK_R { get; } = Code(Keys.R);
        public byte VK_T { get; } = Code(Keys.T);
        public byte VK_Y { get; } = Code(Keys.Y);
        public byte VK_U { get; } = Code(Keys.U);
        public byte VK_I { get; } = Code(Keys.I);
        public byte VK_O { get; } = Code(Keys.O);
        public byte VK_P { get; } = Code(Keys.P);
        public byte VK_F { get; } = Code(Keys.F);
        public byte VK_G { get; } = Code(Keys.G);
        public byte VK_H { get; } = Code(Keys.H);
        public byte VK_J { get; } = Code(Keys.J);
        public byte VK_K { get; } = Code(Keys.K);
        public byte VK_L { get; } = Code(Keys.L);
        public byte VK_Z { get; } = Code(Keys.Z);
        public byte VK_X { get; } = Code(Keys.X);
        public byte VK_C { get; } = Code(Keys.C);
        public byte VK_V { get; } = Code(Keys.V);
        public byte VK_B { get; } = Code(Keys.B);
        public byte VK_N { get; } = Code(Keys.N);
        public byte VK_M { get; } = Code(Keys.M);
        public byte VK_SPACE { get; } = Code(Keys.Space);
        public byte VK_MINUS { get; } = Code(Keys.OemMinus);
        public byte VK_EQUALS { get; } = Code(Keys.OemPlus);
        public byte VK_OPEN_BRACKET { get; } = Code(Keys.OemOpenBrackets);
        public byte VK_CLOSE_BRACKET { get; } = Code(Keys.OemCloseBrackets);
        public byte VK_BACK_SLASH { get; } = Code(Keys.OemBackslash);
        public byte VK_COLON { get; } = Code(Keys.OemSemicolon);
        public byte VK_QUOTE { get; } = Code(Keys.OemQuotes);
        public byte VK_COMMA { get; } = Code(Keys.OemComma);
        public byte VK_PERIOD { get; } = Code(Keys.OemPeriod);
        public byte VK_SLASH { get; } = Code(Keys.OemQuestion);

        public byte getKeyCode() => KeyCode;
        public byte KeyCode { get; }
        public KeyEvent(byte keyCode)
        {
            KeyCode = keyCode;
        }
    }
    public class MouseEvent
    {
        string Button { get; }
        int X, Y;
        public MouseEvent(string button) { Button = button; }
        public MouseEvent(int x, int y)
        {
            X = x;
            Y = y;
        }
        public object getButton() => Button;
        public static string BUTTON1 { get; } = "BUTTON1";
        public static string BUTTON3 { get; } = "BUTTON3";

        internal int getX() => X;

        internal int getY() => Y;
    }
    public class ChangeEvent { }
    public class MouseWheelEvent { }
    public interface ChangeListener { }
    public interface KeyListener
    {
        void keyPressed(KeyEvent key);
        void keyReleased(KeyEvent key);
    }
    public interface MouseListener
    {
        void mousePressed(MouseEvent e);
        void mouseReleased(MouseEvent e);
    }
    public interface MouseMotionListener
    {
        void mouseMoved(MouseEvent e);
        void mouseDragged(MouseEvent e);
    }
    public interface MouseWheelListener { }
}
