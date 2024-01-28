string text = "А роза упала на лапу Азора"; //...определим текст

PrintResult(GetArrayOfWords(text, GetQuantityOfWords(text))); //...выведем результат: тестс задом наперед

int GetQuantityOfWords(string input) //...посчитаем количество слов в тексте
{
    int count = 0;
    foreach (char c in input + '\0')
    {
        if (c == ' ' || c == '\0')
            count++;
    }
    return count;
}

string[] GetArrayOfWords(string input, int size) //...получим массив слов
{
    string[] words = new string[size];
    int i = 0;
    foreach (char c in input)
    {
        if (c != ' ')
            words[i] += c;
        else 
            i++;
    }
    return words;
}

void PrintResult(string[] input)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        if (i != 0)
            Console.Write(input[i] + ' ');
        else
            Console.Write(input[i]);
    }
}