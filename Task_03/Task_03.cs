int[] array = {1, 2, 5, 0, 10, 34};
int index = array.Length-1;

PrintReversedArray(array, index);

void PrintReversedArray(int[] array, int index)
{
	if (index >= 0)
	{
		Console.Write(array[index]);
		if (index != 0)
			Console.Write(" ");
		PrintReversedArray(array, index-1);
	}
}
