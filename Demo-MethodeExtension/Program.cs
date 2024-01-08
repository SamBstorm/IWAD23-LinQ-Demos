namespace Demo_MethodeExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> entiers = new List<int>() { 2, 4, 5, 9, -3, 7, 8 };

            List<int> result = entiers.Filtre<int>((item) => item % 2 == 0);

            Console.WriteLine(result.Count);

            List<string> stringList = entiers.Convertir<int, string>((i) => i.ToString());

            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }

            var entiersAvecCarre = entiers.Convertir((i) => new { value = i, square = i * i });

            foreach (var intSquare in entiersAvecCarre)
            {
                Console.WriteLine($"Le carré de {intSquare.value} est {intSquare.square}");
            }
        }
    }
}
