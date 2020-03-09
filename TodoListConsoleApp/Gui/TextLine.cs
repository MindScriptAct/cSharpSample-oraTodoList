using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TodoListConsoleApp.Gui
{
    class TextLine : GuiObject
    {
        private readonly string textData;

        private AlignType align;

        public TextLine(int x, int y, int width, string textData, AlignType align = AlignType.Left) : base(x, y, width, 1)
        {
            this.textData = textData;
            this.align = align;
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > textData.Length)
            {
                switch (align)
                {
                    case AlignType.Left:
                        // do nothing.
                        break;
                    case AlignType.Center:
                        Console.SetCursorPosition(X + (Width - textData.Length) / 2, Y);
                        break;
                    case AlignType.Right:
                        Console.SetCursorPosition(X + Width - textData.Length, Y);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.Write(textData);
            }
            else
            {
                Console.Write(textData.Substring(0, Width));
            }
        }
    }
}
