class BCipher : ICipher
{
    public string e(string text)
    {
        char[] s = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]))
            {
                s[i] = (char)('я' - (text[i] - 'а'));
            }
            else if (char.IsUpper(c))
            {
                s[i] = (char)('Я' - (text[i] - 'А'));
            }
            else
            {
                s[i] = text[i];
            }
        }

        return new string(s);
    }

    public string d(string c)
    {
        return e(c);
    }
}
