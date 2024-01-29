int m = 1, n = 15;

void PrintNatural(int numberM, int numberN)
{
	if (numberM <= numberN)
	{
		if (numberM == numberN)
			Console.Write($"{numberM}");
		else
			Console.Write($"{numberM}, ");
		numberM++;
		PrintNatural(numberM, numberN);
	}
}

PrintNatural(m, n);
