using System;

namespace Uppgift_1_Listor_inl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnen = new List<string>();

            while (true)
            {
                string namn = Console.ReadLine();

                if (String.IsNullOrEmpty(namn))
                {
                    break;
                }
                namnen.Add(namn);
            }

            namnen.Sort();
            namnen.Reverse();

            foreach (string namn in namnen)
            {
                Console.WriteLine(namn);

            }
        }
    }
}