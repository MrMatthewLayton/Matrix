namespace Matrix
{
    using System;

    internal static class Random
    {
        private static System.Random random;

        static Random()
        {
            random = new System.Random(Guid.NewGuid().GetHashCode());
        }

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }

        public static char Char()
        {
            char result = (char)127;

            while (char.IsControl(result))
            {
                result = (char)random.Next(33, 255);
            }

            return result;
        }
    }
}
