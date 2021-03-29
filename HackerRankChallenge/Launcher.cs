using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenge
{
    static class Launcher
    {
        public static void SalesByMatchLanch()
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
                int result = SalesByMatch.SockMerchant(tabSize, tab);
                Console.WriteLine($" le nombre de pair est : {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("veillez recommencer :");
                goto Retry;
            }
        }
    }
}
