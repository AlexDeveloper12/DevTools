namespace DevTools.UI.Client.Helpers;

public static class PasswordGeneratorLists
{
    public static List<string> Alphabet { get; set; } = new List<string>()
    {
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
        "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y",
        "z"
    };

    public static List<int> Numbers { get; set; } = new List<int>()
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    };

    public static List<string> Symbols { get; set; } = new List<string>()
    {
        "!", "@", ",", ".", "£", "$", "$", "^", "&", "*", "(", ")"
    };
}