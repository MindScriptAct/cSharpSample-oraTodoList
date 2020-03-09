namespace TodoListConsoleApp.Gui
{
    abstract class GuiObject : IRenderable, IPositioning
    {

        private int x;
        private int y;

        public int X
        {
            get => x;
            private set { if (value >= 0) { x = value; } }
        }

        public int Y
        {
            get => y;
            private set { if (value > 0) y = value; }
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        protected GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public abstract void Render();

    }
}
