namespace Matrix
{
    using System.Collections.Generic;

    internal sealed class Column
    {
        private readonly Queue<Character> characters;
        private readonly int maxHeight;
        private readonly int x;
        private int y;

        public Column(int x, int maxHeight)
        {
            this.x = x;
            this.maxHeight = maxHeight;

            characters = new Queue<Character>();
        }

        public void Draw()
        {
            characters.Enqueue(new Character(x, y++));

            if(characters.Count >= 16)
            {
                characters.Dequeue();
            }

            if (y >= maxHeight)
            {
                y = Random.Next(0, maxHeight);
            }

            foreach (Character character in characters)
            {
                character.Draw();
            }
        }
    }
}
