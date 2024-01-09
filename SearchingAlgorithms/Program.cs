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
                Console.WriteLine($"Элемент {target} найден в массиве по индексу {result}.");
            else
                Console.WriteLine($"Элемент {target} не найден в массиве.");

            //бинарный поиск
            int binarySearchResult = BinarySearch(array, target);

            if (binarySearchResult != -1)
                Console.WriteLine($"Элемент {target} найден в массиве по индексу {result}.");
            else
                Console.WriteLine($"Элемент {target} не найден в массиве.");

            //тернарный поиск
            int ternarySearchResult = TernarySearch(array, target);

            if (ternarySearchResult != -1)
                Console.WriteLine($"Элемент {target} найден в массиве по индексу {result}.");
            else
                Console.WriteLine($"Элемент {target} не найден в массиве.");

            //экспоненциальный поиск
            int exponentialySearchResult = ExponentialSearch(array, target);

            if (exponentialySearchResult != -1)
                Console.WriteLine($"Элемент {target} найден в массиве по индексу {result}.");
            else
                Console.WriteLine($"Элемент {target} не найден в массиве.");
        }

        static int LinearSearch(int[] array, int target)
        {
            Console.WriteLine("Линейный поиск ");
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
            Console.WriteLine("Бинарный поиск ");
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
        static int TernarySearch(int[] array, int target)
        {
            Console.WriteLine("Тернарный поиск ");
            int counter = 0;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                counter++;
                int partitionSize = (right - left) / 3;
                int mid1 = left + partitionSize;
                int mid2 = right - partitionSize;

                if (array[mid1] == target)
                {
                    Console.WriteLine("Количество шагов: " + counter);
                    return mid1;
                }
                else if (array[mid2] == target)
                {
                    Console.WriteLine("Количество шагов: " + counter);
                    return mid2;
                }
                else if (target < array[mid1])
                {
                    right = mid1 - 1;
                }
                else if (target > array[mid2])
                {
                    left = mid2 + 1;
                }
                else
                {
                    left = mid1 + 1;
                    right = mid2 - 1;
                }
            }

            Console.WriteLine("Количество шагов: " + counter);
            return -1; 
        }

        //экспоненциальный поиск
        static int BinarySearch(int[] array, int target, int left, int right)
        {
            int counter = 0;
            while (left <= right)
            {
                counter++;
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    Console.WriteLine("Количество шагов: " + counter);
                    return mid; // Возвращаем индекс элемента, если он найден
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine("Количество шагов: " + counter);
            return -1; // Возвращаем -1, если элемент не найден
        }

        static int ExponentialSearch(int[] array, int target)
        {
            Console.WriteLine("Экспоненциальный поиск ");
            int bound = 1;

            while (bound < array.Length && array[bound] < target)
            {
                bound *= 2;
            }

            int left = bound / 2;
            int right = Math.Min(bound, array.Length - 1);

            return BinarySearch(array, target, left, right);
        }
    }

}