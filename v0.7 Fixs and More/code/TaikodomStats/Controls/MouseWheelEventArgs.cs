using System;

namespace TaikodomStats.Controls
{
    public class MouseWheelEventArgs : EventArgs
    {
        private readonly double delta;

        public MouseWheelEventArgs(double delta)
        {
            this.delta = delta;
        }

        public double Delta
        {
            get { return delta; }
        }

        // Use handled to prevent the default browser behavior!
        public bool Handled { get; set; }
    }
}
