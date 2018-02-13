using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASSESSMENT
{
    public class random
    {
        public List<int> randomnumber (int min, int max)
        {
            Random random = new Random();
            List<int> available = new List<int>(20);
            List<int> result = new List<int>(20);

            for (int i = min; i <= max; i++)
            {
                available.Add(i);
            }

            while (available.Count > 0)
            {
                int index = random.Next(available.Count);
                result.Add(available[index]);
                available.RemoveAt(index);
            }
            return result;
        }
    }
}