namespace Labc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slumpTal = "81575187k62387623593465387469";
            long totalSumma = 0;

            // Endast lop 3 gånger 
            for (int i = 0; i < 3; i++)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ange ett tal mellan 1-9:");
                Console.ResetColor();

                string användarTal = Console.ReadLine();
                int förstaIndex = slumpTal.IndexOf(användarTal);

                if (förstaIndex != -1)
                {
                    int andraIndex = slumpTal.IndexOf(användarTal, förstaIndex + 1);

                    if (andraIndex != -1)
                    {
                        // matchning nummret här
                        string matchandeDel = slumpTal.Substring(förstaIndex, (andraIndex - förstaIndex) + 1);

                        // vi adderar talet
                        totalSumma += long.Parse(matchandeDel);

                        // slutresultat
                        Console.Write(slumpTal.Substring(0, förstaIndex));
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(matchandeDel);
                        Console.ResetColor();
                        Console.WriteLine(slumpTal.Substring(andraIndex + 1));
                    }
                    else
                    {
                        Console.WriteLine(slumpTal);
                    }
                }
                else
                {
                    Console.WriteLine(slumpTal);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Totala summan adderad blir: {totalSumma}");
            Console.ResetColor();

            Console.WriteLine("Tryck på valfri tangent för att avsluta");
            Console.ReadKey();
        }
    }
}
