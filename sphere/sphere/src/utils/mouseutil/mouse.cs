using System.Diagnostics;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace sphere.src.utils.mouseutil
{
    internal class mouse
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public static void click(int delay)
        {
            Point currentPosition = System.Windows.Forms.Cursor.Position;
            mouse_event(MOUSEEVENTF_LEFTDOWN, currentPosition.X, currentPosition.Y, 0, 0);
            Thread.Sleep(delay);
            mouse_event(MOUSEEVENTF_LEFTUP, currentPosition.X, currentPosition.Y, 0, 0);
        }

        public static void moverel(int dx, int dy)
        {
            mouse_event(MOUSEEVENTF_MOVE, dx, dy, 0, 0);
        }

        static void delay(double milliseconds)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long ticks = (long)(TimeSpan.TicksPerMillisecond * milliseconds);
            while (stopwatch.ElapsedTicks < ticks) { }
            stopwatch.Stop();
        }
    }
}
