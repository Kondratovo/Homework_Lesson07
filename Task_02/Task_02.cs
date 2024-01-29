int m = 3;
int n = 2;

int result = AckermannFunction(m, n);
Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");

int AckermannFunction(int m, int n)
{
	if (m == 0)
		return n + 1;
	else if (n == 0)
		return AckermannFunction(m - 1, 1);
	else
		return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
