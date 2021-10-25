using System;
using System.Collections.Generic;
using System.Text;

namespace JsonXmlCollection
{
    class Exercise1
    {
        private static List<int> numberList = new List<int>();
        private static int minBorder = 25;
        private static int maxBorder = 50;
        private static int maxValueRnd = 101;
        private static int limitList = 100;
        private static Random random = new Random();

        /// <summary>
        /// Заполняет список 100 значениями в диапозоне от 0 до 100
        /// </summary>
        private void FillingList()
        {
            for (int i = 0; i < limitList; i++)
            {
                numberList.Add(random.Next(maxValueRnd));
            }
        }

        /// <summary>
        /// Выводит список чисел на экран
        /// </summary>
        private void PrintList()
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(numberList[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Удаляет значения из списка в заданном диапозоне
        /// </summary>
        private void DeleteRangeValue()
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] > minBorder && numberList[i] < maxBorder)
                {
                    numberList.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Выполняет по очереди функции наполнения, отображение, удаления и отображения содержимого списка
        /// </summary>
        public void ExecuterExercise1()
        {
            FillingList();
            PrintList();
            DeleteRangeValue();
            PrintList();
        }
    }
}
