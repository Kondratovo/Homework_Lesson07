string text = "А роза упала на лапу Азора"; //...определим текст
string reversedText = "";

reversedText = GetReversedText(GetArrayOfWords(text, GetQuantityOfWords(text))); //...сохраним текст задом наперед
Console.Write(reversedText); //...выведем результат

int GetQuantityOfWords(string input) //...посчитаем количество слов в тексте
{
    int count = 0;
    foreach (char c in input)
    {
        if (c == ' ')
            count++;
    }
    return count + 1;
}

string[] GetArrayOfWords(string input, int size) //...получим массив слов
{
    string[] words = new string[size];
    int i = 0;
    foreach (char c in input)
    {
        if (c != ' ')
            words[i] += c;
        if (c == ' ')
            i++;
    }
    return words;
}

string GetReversedText(string[] input) //...сформируем текст задом наперед
{
    string reversedText = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        if (i != 0)
            reversedText += input[i] + ' ';
        else
            reversedText += input[i];
    }
    return reversedText;
}
