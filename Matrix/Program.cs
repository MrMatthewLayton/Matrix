namespace Matrix
{
    using static System.Console;

    internal static class Program
    {
        private const int WindowWidth = 80;
        private const int WindowHeight = 25;

        private static readonly Column[] columns;

        static Program()
        {
            columns = new Column[WindowWidth];

            for (int i = 0; i < WindowWidth; i++)
            {
                columns[i] = new Column(i, WindowHeight - 1);
            }
        }

        private static void Main(string[] args)
        {
            Initialize();

            while (true)
            {
                columns[Random.Next(0, WindowWidth)].Draw();
            }
        }

        private static void Initialize()
        {
            SetWindowSize(WindowWidth, WindowHeight);
            SetBufferSize(WindowWidth, WindowHeight);

            Title = "Matrix";

            CursorVisible = false;
        }
    }
}
