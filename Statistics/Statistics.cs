using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public float max, min, average = 0;
        public List<float> CalculateStatistics(List<float> numbers) {
            this.min = numbers.First();
            this.max = numbers.First();
            foreach (var item in numbers)
            {
                this.average += item;
                if (min > item)
                {
                    this.min = item;
                }
                if (max < item)
                {
                    this.max = item;
                }
            }
            average /= numbers.Count;
            return numbers;
        }
    }
}
