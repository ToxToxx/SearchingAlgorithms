namespace SearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Линейный поиск
            int[] array = { 2, 5, 8, 12, 16, 23, 38, 45, 50 };

            Console.Write("Введите элемент для линейного поиска поиска: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int result = LinearSearch(array, target);

            if (result != -1)
            {
                Console.WriteLine($"Элемент {target} найден в массиве по индексу {result}.");
            }
            else
            {
                Console.WriteLine($"Элемент {target} не найден в массиве.");
            }

            //бинарный поиск

            int binarySearchResult = BinarySearch(array, target);

            if (binarySearchResult != -1)
            {
                Console.WriteLine($"Элемент {target} найден в массиве по индексу {result}.");
            }
            else
            {
                Console.WriteLine($"Элемент {target} не найден в массиве.");
            }

            //тернарный поиск
        }

        static int LinearSearch(int[] array, int target)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                if (array[i] == target)
                {
                    Console.WriteLine("Количество шагов: " + counter);
                    return i; 
                }
            }
            Console.WriteLine("Количество шагов: " + counter);
            return -1; 
        }

        static int BinarySearch(int[] array, int target)
        {
            int counter = 0;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                counter++;
                if (array[middle] == target)
                {
                    
                    Console.WriteLine("Количество шагов: " + counter);
                    return middle; 
                }
                else if (array[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            Console.WriteLine("Количество шагов: " + counter);
            return -1; 
        }
    }

}