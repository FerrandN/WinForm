using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassTest
{
    public class Addition
    {
        public List<int> numbers = new List<int>();

        public int CalculateResults()
        {
            int result = 0;
            foreach (int number in numbers)
            { result += number; }
            return result;
        }

        public void Reset()
        {
            numbers.Clear();
        }

        public void AddNumbers(int numberToAdd)
        {
            numbers.Add(numberToAdd);
        }
    }
}
