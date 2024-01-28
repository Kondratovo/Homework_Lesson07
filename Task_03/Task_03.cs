string text = "saippuakivikauppias";

string GetInvertedText(string input)            //...перевернем исходную строку
{
    string invText = "";
    for (int i = input.Length-1; i >= 0; i--)
    {
        invText += input[i];
    }
    return invText;
}

bool IsPalindrome(string str)
{
    bool isEqual = false;
    str = str.ToLower();               //...приводим к нижнему регистру
    if (str == GetInvertedText(str))   //...сравниваем исходную строку с перевернутой
    {
        isEqual = true;
    }
    return isEqual;
}

Console.Write(IsPalindrome(text) ? "Да" : "Нет");