string text = "AbCd1fGh";

string GetLowerString (string text)
{
    text = text.ToLower();
    return text;
}

Console.Write(GetLowerString(text));
