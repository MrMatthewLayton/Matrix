namespace Matrix
{
    using System;
    using static Colorful.Console;

    internal sealed class Character
    {
        private readonly int x;
        private readonly int y;
        private readonly char character;

        private int colorIndex = 15;

        public Character(int x, int y)
        {
            this.x = x;
            this.y = y;

            character = Random.Char();
        }

        public void Draw()
        {
            SetCursorPosition(x, y);
            Write(character, Palette.GetColor(Math.Max(colorIndex--, 0)));
        }
    }
}
