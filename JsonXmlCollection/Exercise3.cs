using System;
using System.Collections.Generic;
using System.Text;

namespace JsonXmlCollection
{
    class Exercise3
    {
        private HashSet<int> _setNumber = new HashSet<int>();

        public void EnterNumber()
        {
            bool flag = true;
            string numberStr;
            int number;
            while (flag)
            {
                Console.WriteLine("Введите число -");
                numberStr = Console.ReadLine();
                if (numberStr == "")
                {
                    flag = false;
                    break;
                }
                try
                {
                    number = Convert.ToInt32(numberStr);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое число.");
                    throw;
                }
                CheckNumberInSet(number);
            }
            
        }

        private void CheckNumberInSet(int number)
        {
            if (_setNumber.Contains(number))
            {
                Console.WriteLine($"Число {number} уже есть во множестве.");
            }
            else
            {
                Console.WriteLine($"Число {number} добавлено во множестве.");
                _setNumber.Add(number);
            }
        }
    }
}
