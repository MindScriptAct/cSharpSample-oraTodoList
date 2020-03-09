using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListConsoleApp.Gui
{
    class Frame : GuiObject
    {
        private char frameChar;

        public Frame(int x, int y, int width, int height, char frameChar = '#') : base(x, y, width, height)
        {
            this.frameChar = frameChar;
        }

        public override void Render()
        {
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(X, Y + y);
                for (int x = 0; x < Width; x++)
                {
                    if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                    {
                        Console.Write(frameChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
        }

        public void SetFrameChar(char frameChar)
        {
            this.frameChar = frameChar;
        }
    }
}

