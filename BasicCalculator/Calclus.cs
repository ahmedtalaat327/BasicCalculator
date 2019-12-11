using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{

    public  class Calclus
    {
        public string[] ReturnedResult { get; set; }
        public char[] SpecialOperators { get; set; } = {'+','-','*','/'};
        public  T[] RemoveAt<T>(T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

            return dest;
        }
        public  T[] Add<T>(T[] target, params T[] items)
        {
            // Validate the parameters
            if (target == null)
            {
                target = new T[] { };
            }
            if (items == null)
            {
                items = new T[] { };
            }

            // Join the arrays
            T[] result = new T[target.Length + items.Length];
            target.CopyTo(result, 0);
            items.CopyTo(result, target.Length);
            return result;
        }
        private String[] AddWithShifting(String[] target ,String  item)
        {
             
            int newSize = target.Length + 1;
            String []array = new String[newSize];

            array[0] = item;
            for (int d = 0; d < target.Length; d++)
            {
                array[d + 1] = target[d];
            }

          

           

            return array;
        }
        public void ReactToArray(string[]digits)
        {

            for(int i = 0; i < digits.Length; i++)
            {

                if (digits[i] == "/")
                {
                    double newDigit = Double.Parse(digits[i - 1]) / Double.Parse(digits[i + 1]);
                    digits = RemoveAt(digits, i + 1);
                    digits = RemoveAt(digits, i);
                    digits = RemoveAt(digits, i - 1);
                    digits = AddWithShifting(digits, newDigit.ToString("0.######"));
                    break;
                }
                if (digits[i] == "*")
                {
                    double newDigit = Double.Parse(digits[i - 1]) * Double.Parse(digits[i + 1]);
                    digits = RemoveAt(digits, i + 1);
                    digits = RemoveAt(digits, i);
                    digits = RemoveAt(digits, i - 1);
                    digits = AddWithShifting(digits, newDigit.ToString("0.######"));
                    break;
                }
                if (digits[i] == "+")
                {
                    double newDigit = Double.Parse(digits[i - 1]) + Double.Parse(digits[i + 1]);
                    digits = RemoveAt(digits, i + 1);
                    digits = RemoveAt(digits, i);
                    digits = RemoveAt(digits, i - 1);
                    digits = AddWithShifting(digits, newDigit.ToString("0.######"));
                    break;
                }
                if (digits[i] == "-")
                {
                    double newDigit = Double.Parse(digits[i - 1]) - Double.Parse(digits[i + 1]);
                    digits = RemoveAt(digits, i + 1);
                    digits = RemoveAt(digits, i);
                    digits = RemoveAt(digits, i - 1);
                    digits = AddWithShifting(digits, newDigit.ToString("0.######"));
                    break;
                }
            }
            foreach(String ele in digits)
            {
                Console.WriteLine(ele);
            }
            if (digits.Length > 1)
            {
                ReactToArray(digits);
            }
            else
            {
                ReturnedResult = digits;
            }
           
        }
        public String[] getResult()
        {
            return ReturnedResult;
        }
       
    }
}
