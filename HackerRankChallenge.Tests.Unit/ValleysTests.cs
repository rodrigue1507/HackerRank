using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenge.Tests.Unit
{
    [TestFixture]
    class ValleysTests
    {
        [TestCase("UDDDUDUU")]
        public void GiveTotalValleys(string str)
        {
            Valleys valleys = new Valleys();
            int totalValley = valleys.CountingValleys(str);
            totalValley.Should().Be(1);
        }
    }
}
