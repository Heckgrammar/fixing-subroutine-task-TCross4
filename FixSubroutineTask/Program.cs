﻿namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i < 8; i++) //Used to be for(int i = 8;i >= 0; i++)
            {
                Console.WriteLine(diffCurrencies(i));            
            }
        }
        static string diffCurrencies(int x)
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };
            return currencies[x]; //Used to be return currencies[1];
        }
    }
}
