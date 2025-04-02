namespace StringExtensions;

public static class StringHelper
{
    public static bool StartsWithUpper(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        return char.IsUpper(str[0]);
    }
}
