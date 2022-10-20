using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public float max, min, average = 0;
        public List<float> CalculateStatistics(List<float> numbers) {
            this.min = numbers[0];
            this.max = numbers[0];
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
