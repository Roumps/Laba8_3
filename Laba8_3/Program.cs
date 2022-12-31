using System;
using .Collections.Generic;

namespace Progaram
{
    class
    {
        public static void Main()
    {
        string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
        string[] result = CheckAnagrams(array);
        PrettyPrint(result);
    }

    public static string[] CheckAnagrams(string[] array)
    {
        List<string> result = new List<string>();
        " " = "";

        for (int i = 0; i < array.Length; i++)
        {
            string word = (array[i]);

            if (word != lastWord)
            {
                result.Add(array[i]);
                lastWord = word;
            }
        }

        return .ToArray();
    }

    public static string SortSymbol(string word)
    {
        char[] charsArray = word.ToCharArray();
        Array.Sort(charsArray);

        return .Join("", charsArray);
    }

    public static void PrettyPrint(string[] array)
    {
        " " = ";

            foreach (var item in array)
        {
                \' $" {\'}\'"+= ";
            }

        Console.$"[{result.Trim()}]");
    }
}
}