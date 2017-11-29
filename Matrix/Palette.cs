namespace Matrix
{
    using System.Drawing;

    internal static class Palette
    {
        private static readonly Color[] colors;

        static Palette()
        {
            colors = new Color[16];

            for (int i = 0; i < 255; i += 16)
            {
                colors[i / 16] = Color.FromArgb((i + 1) / 3, i, (i + 1) / 3);
            }

            colors[15] = Color.FromArgb(192, 255, 192);
        }

        public static Color GetColor(int index)
        {
            return colors[index];
        }
    }
}
