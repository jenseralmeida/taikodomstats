using System;
using System.Windows;
using System.Windows.Browser;

namespace TaikodomStats.Controls
{
    public class MouseWheelUtil
    {
        public event EventHandler<MouseWheelEventArgs> Moved;
        private static Worker worker;
        private bool isMouseOver;

        public MouseWheelUtil(UIElement element)
        {

            if (worker == null)
                worker = new Worker();

            worker.Moved += HandleMouseWheel;

            element.MouseEnter += HandleMouseEnter;
            element.MouseLeave += HandleMouseLeave;
            element.MouseMove += HandleMouseMove;
        }

        private void HandleMouseWheel(object sender, MouseWheelEventArgs args)
        {
            if (isMouseOver)
                Moved(this, args);
        }

        private void HandleMouseEnter(object sender, EventArgs e)
        {
            isMouseOver = true;
        }

        private void HandleMouseLeave(object sender, EventArgs e)
        {
            isMouseOver = false;
        }

        private void HandleMouseMove(object sender, EventArgs e)
        {
            isMouseOver = true;
        }

        private class Worker
        {

            public event EventHandler<MouseWheelEventArgs> Moved;

            public Worker()
            {

                if (HtmlPage.IsEnabled)
                {
                    HtmlPage.Window.AttachEvent("DOMMouseScroll", HandleMouseWheel);
                    HtmlPage.Window.AttachEvent("onmousewheel", HandleMouseWheel);
                    HtmlPage.Document.AttachEvent("onmousewheel", HandleMouseWheel);
                }

            }

            private void HandleMouseWheel(object sender, HtmlEventArgs args)
            {
                double delta = 0;

                ScriptObject eventObj = args.EventObject;

                if (eventObj.GetProperty("wheelDelta") != null)
                {
                    delta = ((double)eventObj.GetProperty("wheelDelta")) / 120;


                    if (HtmlPage.Window.GetProperty("opera") != null)
                        delta = -delta;
                }
                else if (eventObj.GetProperty("detail") != null)
                {
                    delta = -((double)eventObj.GetProperty("detail")) / 3;

                    if (HtmlPage.BrowserInformation.UserAgent.IndexOf("Macintosh") != -1)
                        delta = delta * 3;
                }

                if (delta != 0 && Moved != null)
                {
                    var wheelArgs = new MouseWheelEventArgs(delta);
                    Moved(this, wheelArgs);

                    if (wheelArgs.Handled)
                        args.PreventDefault();
                }
            }
        }
    }
}
