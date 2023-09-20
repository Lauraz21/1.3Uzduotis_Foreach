namespace _1._3Uzduotis_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pays = { 500, 200, 300 };
            calculateGpm(pays);
        }
        public static void calculateGpm(int[] pays)
        {
            Console.WriteLine("GPM: ");

            foreach (int item in pays)
            {
                if (item < 0)
                {
                    return;
                }
                Console.WriteLine(item * 0.15);
            }
        }
    }
}