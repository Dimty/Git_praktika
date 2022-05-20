namespace Git_praktika
{
    static class Program
    {
        public static void Main(string[] args)
        {
            foreach (var item in 5)
            {
                Console.WriteLine(item);
            }
        }

        static void Sum(int[] arr)
        {
            var sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}