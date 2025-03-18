namespace axtarisVeSiralama
{
    internal class Program
    {
        /*static void Main(string[] args)
        {

            Console.WriteLine("nece eded daxil etmek isteyirsiz ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("zehmet olmasa tekrar ceht edin");
                return;
            }
            Console.WriteLine("ededleri daxil et ");
            int[] array = new int[num];
            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            checkout(array);
            Console.WriteLine("sort :");
            foreach (int i in array)
                Console.WriteLine(i);
        }

        static int[] Insertion_Sort(int[] array)
        {
            int key1;
            for (int i = 1; i < array.Length; i++)
            {
                key1 = i;
                for (int key = key1 - 1; key >= 0; key--, key1--)
                {
                    if (array[key] > array[key1])
                        (array[key], array[key1]) = (array[key1], array[key]);
                }

            }
            return array;
        }

        static int[] checkout(int[] array)
        {
            bool flaq = true;
            while (flaq)
            {
                flaq = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        flaq = true;
                        Insertion_Sort(array);
                    }
                }
            }
            if (!flaq)
                return array;
            return default;
        }*/
    }
}
       /* static void Main(string[] args)
        {

            int[] array = {2,4,1,5,3};
            Insertion_Sort(array);
            Console.WriteLine("sort :");
            foreach (int i in array)
                Console.WriteLine(i);
        }

        static int[] Insertion_Sort(int[] array)
        {
            int key1;
            for (int i = 1; i < array.Length; i++)
            {
                key1 = i;
                for (int key = key1 - 1; key >= 0; key--, key1--)
                {
                    if (array[key] > array[key1])
                        (array[key], array[key1]) = (array[key1], array[key]);
                }

            }
            return array;
        }*/