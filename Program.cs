string slumpTal = "81575187k62387623593465387469";
long totalSumma = 0;


for (int i = 0; i < slumpTal.Length; i++)
{

    if (char.IsDigit(slumpTal[i]))
    {
        char startSiffra = slumpTal[i];

        for (int j = i + 1; j < slumpTal.Length; j++)
        {
            if (slumpTal[j] == startSiffra)
            {
                bool allaSiffror = true;
                for (int k = i + 1; k < j; k++)
                {
                    if (!char.IsDigit(slumpTal[k]))
                    {
                        allaSiffror = false;
                        break;
                    }
                }

                if (allaSiffror)
                {
                    string matchandeDel = slumpTal.Substring(i, (j - i) + 1);
                    totalSumma += long.Parse(matchandeDel);

                    Console.WriteLine(slumpTal.Substring(0, i));
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(matchandeDel);
                    Console.ResetColor();
                    Console.WriteLine(slumpTal.Substring(j + 1));
                }
            }
        }

    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Totala summan adderad blir: {totalSumma}");
Console.ResetColor();

Console.WriteLine("Tryck på valfri tnagent för att avsluta");
Console.ReadKey();
