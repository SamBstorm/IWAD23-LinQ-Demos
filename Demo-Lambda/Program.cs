namespace Demo_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> entiers = new List<int>() { 2, 4, 5, 9, -3, 7, 8};

            //Func<int, bool> filtrePair = delegate (int item) { return item % 2 == 0; };
            //List<int> result = Filtre<int>(entiers, filtrePair);

            List<int> result = Filtre<int>(entiers, (item) => item % 2 == 0);

            Console.WriteLine(result.Count);
        }

        static List<T> Filtre<T>(List<T> list, Func<T, bool> fonctionFiltre)
        {
            List<T> result = new List<T>();

            foreach (T item in list)
            {
                if (fonctionFiltre(item)) result.Add(item);
            }

            return result;
        }
    }
}
