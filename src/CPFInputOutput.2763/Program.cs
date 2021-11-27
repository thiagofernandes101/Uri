using System;

namespace CPFInputOutput._2763
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf = Console.ReadLine();
            string[] cpfParts = cpf.Split(new char[] { '.', '-' });

            foreach (string part in cpfParts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
