using System;

namespace HackerRankChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesByMatch salesByMatch = new SalesByMatch();
            Retry:
            Console.WriteLine("donnez la taille de votre tableau");
            int tabSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"la taille de votre tableau est : {tabSize}");
            Console.WriteLine("Entrer les elements de votre tableau sur la meme ligne separe d'un espace :");
            int[] tab = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            try
            {
                int result = salesByMatch.SockMerchant(tabSize, tab);
                Console.WriteLine($" le nombre de pair est : {result}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("veillez recommencer :");
                goto Retry;
            }
        }
    }
}
