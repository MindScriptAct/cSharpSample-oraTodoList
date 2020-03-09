using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListConsoleApp.Gui
{
    class Button : GuiObject
    {
        private string labelText;

        public Button(int x, int y, int width, int height, string labelText) : base(x, y, width, height)
        {
            this.labelText = labelText;
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }
    }
}
