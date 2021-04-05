using System;

namespace HackerRankChallenge
{
    public class Valleys
    {
        public int CountingValleys(string path)
        {
            bool seaLevel = true;
            int down = 0;
            int up = 0;
            int mountain = 0;
            int valley = 0;
            bool isUphill = false;
            foreach (var level in path.ToUpper())
            {
                if (seaLevel)
                {
                    if (level == 'U')
                    {
                        isUphill = true;
                    }
                    else
                    {
                        isUphill = false;
                    }
                    seaLevel = false;
                }
                if (level == 'U')
                {
                    up++;
                }
                else
                {
                    down++;
                }
                if (up == down)
                {
                    if(isUphill == true)
                    {
                        mountain++;
                    }
                    else
                    {
                        valley++;
                    }
                    seaLevel = true;
                }
            }
            return valley;
        }
    }
}
