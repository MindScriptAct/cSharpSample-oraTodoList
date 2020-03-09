using System;
using TodoListConsoleApp.Gui;
using TodoListConsoleApp.Model;

namespace TodoListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TextLine textLine1 = new TextLine(25, 2, 90, "Demo text goes here!");
            textLine1.Render();
            TextLine textLine2 = new TextLine(25, 4, 90, "Demo text goes here!", AlignType.Center);
            textLine2.Render();
            TextLine textLine3 = new TextLine(25, 6, 90, "Demo text goes here!", AlignType.Right);
            textLine3.Render();

            Button button1 = new Button(20, 15, 20, 4, "Show list");
            button1.Active = true;
            button1.Render();
            Button button2 = new Button(50, 15, 20, 5, "Edit list");
            button2.Render();
            Button button3 = new Button(80, 15, 20, 3, "Quit");
            button3.Render();

            Console.ReadKey();
        }
    }
}