class BCipher : ICipher
{
    public string e(string text)
    {
        char[] s = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (char.IsLower(c))
            {
                s[i] = (char)('я' - (c - 'а'));
            }
            else if (char.IsUpper(c))
            {
                s[i] = (char)('Я' - (c - 'А'));
            }
            else
            {
                s[i] = c;
            }
        }

        return new string(s);
    }

    public string d(string c)
    {
        return e(c);
    }
}