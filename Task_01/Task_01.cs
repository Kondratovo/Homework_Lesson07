char[,] chars = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'},
};

string GetStringFromChar(char [,] chars)
{
    string text = "";
    foreach (char c in chars)
    {
        text += c;
    }
    return text;
}

Console.Write(GetStringFromChar(chars));