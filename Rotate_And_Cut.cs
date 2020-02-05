using System;

namespace Kattis_Rotate_And_Cut
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int rotation = int.Parse(line[0]);
                string message = line[1];

                for(int j = 0; j < rotation; j++)
                {
                    if (message.Length < 4)
                    {
                        break;
                    }
                    message = message.Remove(0, (message.Length / 4));
                }

                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}
