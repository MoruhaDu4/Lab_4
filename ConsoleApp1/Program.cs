namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = 17;
            int N = (int)(20 + 0.6 * K);

            int[] array = new int[N];

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(10, 101);
            }

            Console.WriteLine("Вихiдний масив:");
            PrintArray(array);

          
            InsertionSort(array);

            Console.WriteLine("Вiдсортований масив:");
            PrintArray(array);

            Console.Write("Введiть ключове значення: ");
            int key = int.Parse(Console.ReadLine());

            int count = CountOccurrences(array, key);
            Console.WriteLine($"Кiлькiсть входжень значення {key}: {count}");

            int index = BinarySearch(array, key);
            if (index != -1)
            {
                Console.WriteLine($"Значення {key} знаходиться на позицiї {index}");
            }
            else
            {
                Console.WriteLine($"Значення {key} не знайдено в масивi");
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        static int CountOccurrences(int[] array, int key)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    count++;
                }
            }
            return count;
        }

        static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == key)
                {
                    return middle;
                }
                else if (array[middle] < key)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}
    
