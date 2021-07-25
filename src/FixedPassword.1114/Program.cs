using System;

namespace FixedPassword._1114
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                if (Convert.ToInt32(Console.ReadLine()) == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
