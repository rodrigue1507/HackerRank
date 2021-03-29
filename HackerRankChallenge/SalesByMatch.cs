using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenge
{
    public class SalesByMatch
    {
        public int SockMerchant(int n, int[] ar)
        {
            var checkOneTime = new HashSet<int>();
            if ((n >= 1 || n <= 100) && (n == ar.Length))
            {
                int result = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] >= 1 || ar[i] <= 100)
                    {
                        if (checkOneTime.Add(ar[i]))
                        {
                            int sPair = SockPair(ar[i], ar);
                            result += sPair;
                        }
                    }
                    else throw new Exception("cette valeur du tableau n'est pas compris entre 1 et 100");
                }
                return result;
            }
            else throw new Exception("la longeur du tableau spécifié n'est pas compris entre  1 et 100 ou est différente de la longeur du tableau");
        }

        private static int SockPair(int TabElm, int[] ar)
        {
            int result = 0;
            int elmFrequency = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (TabElm == ar[i])
                    elmFrequency++;
            }
            if (elmFrequency == 2)
                return 1;
            while(elmFrequency - 2 >= 0)
            {
                elmFrequency -= 2;
                result++;
            }
            return result;
        }
    }
}
