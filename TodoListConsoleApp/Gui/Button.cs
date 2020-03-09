using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListConsoleApp.Gui
{
    class Button : GuiObject
    {
        private Frame frame;
        private TextLine label;

        private bool active;

        public bool Active
        {
            get => active;
            set
            {
                if (active != value)
                {
                    active = value;
                    frame.SetFrameChar(active ? '#' : '+');
                }
            }
        }

        public Button(int x, int y, int width, int height, string labelText) : base(x, y, width, height)
        {
            label = new TextLine(x + 1, y + 1 + (int)Math.Floor((double)(height - 3) / 2), width - 2, labelText, AlignType.Center);
            frame = new Frame(x, y, width, height, '+');
        }


        public override void Render()
        {
            frame.Render();
            label.Render();
        }
    }
}
