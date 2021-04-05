using FluentAssertions;
using NUnit.Framework;

namespace HackerRankChallenge.Tests.Unit
{
    [TestFixture]
    class SalesByMatchTests
    {

        //[TestCase(7,new int[] {1,2,1,2,1,3,2})]
        [TestCase(new int[] { 10,20,20,10,10,30,50,10,20})]
        public void GiveTotalPairsSocks(int[] ar)
        {
            //SalesByMatch salesByMatch = new SalesByMatch();
            //int totalPair = salesByMatch.SockMerchant(n,ar);
            //totalPair.Should().Be(3);
            SalesByMatchWithDictionary salesByMatchDic = new SalesByMatchWithDictionary();
            int totalPair = salesByMatchDic.SockMerchant( ar);
            totalPair.Should().Be(3);
        }
    }
}
