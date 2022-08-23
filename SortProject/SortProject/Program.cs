using System;
using Sort;

namespace SortProjcet
{
    class Program
    {
        static void Main()
        {            
            SetSort qs = new SetSort(7);

            qs.SetRandomArray();
            Console.WriteLine($"Массив со случайными числами: {string.Join(", ", qs.myset)}");

            qs.HoarSort();
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", qs.myset)}");
            Console.WriteLine($"Количество операций по обмену элементов: {qs.Count}");

            qs.ReverseArray();
            Console.WriteLine($"Инверсия массива: {string.Join(", ", qs.myset)}");
        }
    }
}