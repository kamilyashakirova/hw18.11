class ACipher : ICipher
{
    public string e(string text)
    {
        char[] s = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            s[i] = (char)(text[i] + 1);
        }

        return new string(s);
    }
    public string d(string c)
    {
        char[] s = new char[c.Length];

        for (int i = 0; i < c.Length; i++)
        {
            s[i] = (char)(c[i] - 1);
        }

        return new string(s);
    }
}
