using System.Collections.Generic;

namespace HackerRankChallenge
{
    public class SalesByMatchWithDictionary
    {
        public int SockMerchant(int[] ar)
        {
            var dic = new Dictionary<int,int>();
            int result = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (!dic.ContainsKey(ar[i]))
                {
                    dic.Add(ar[i],1);
                }
                else
                {
                    dic[ar[i]]++;
                }       
            }
            foreach (var key  in dic.Keys)
            {
                result += dic[key]/2;
            }
            return result;
        }
    }
}
