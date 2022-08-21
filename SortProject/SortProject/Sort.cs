using System;

namespace Sort
{
    public class SetSort
    {
        private int count = 0;

        // Создание свойства только для чтения
        public int Count
        {
            get { return count; }
        }

        // Пустой список, с которым в дальнейшим будут вестись все манипуляции методов класса
        public int[]? myset;

        // Конструктор для создания пустого списка, чтобы заполнить его случайными числами
        public SetSort(int value)
        {
            this.myset = new int[value];
        }

        // По сути синтаксический сахар, чтобы вызывать метод из Main'а, не передавая параметры
        public void HoarSort()
        {
            if(myset != null)
            {
                InternalHoarSort(myset, 0, myset.Length - 1);
            }            
        }

        // Быстрая сортировка Тони Хоара
        private void InternalHoarSort(int[] set, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }
            else
            {
                int pivotIndex = GetPivotIndex(set, leftIndex, rightIndex);
                InternalHoarSort(set, leftIndex, pivotIndex - 1);
                InternalHoarSort(set, pivotIndex + 1, rightIndex);                
            }
        }

        private int GetPivotIndex(int[] set, int startIndex, int endIndex)
        {
            int pivot = startIndex - 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (set[i] < set[endIndex])
                {
                    pivot++;
                    Swap(ref set[pivot], ref set[i], ref count);
                }
            }
            pivot++;
            Swap(ref set[pivot], ref set[endIndex], ref count);
            return pivot;
        }

        private void Swap(ref int a, ref int b, ref int count)
        {
            int temp = a;
            a = b;
            b = temp;
            count++;
        }

        // Инверсия существующего списка
        public void ReverseArray()
        {
            if (myset != null)
            {
                int n = myset.Length;
                int middle = n / 2;
                int temp;

                for (int i = 0; i < middle; i++)
                {
                    temp = myset[i];
                    myset[i] = myset[n - i - 1];
                    myset[n - i - 1] = temp;
                }
            }
            else
            {
                return;
            }

        }

        // Заполнение списка случайными числами в диапазоне от -20 до 20
        public void SetRandomArray()
        {
            if (myset != null)
            {
                Random rnd = new Random();
                for (int i = 0; i <= myset.Length - 1; i++)
                {
                    myset[i] = rnd.Next(-20, 20);
                }
            }
            else
            {
                return;
            }

        }
    }
}
