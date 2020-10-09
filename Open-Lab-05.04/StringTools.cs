using System;
using System.Text.RegularExpressions;
namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original) => Regex.Replace(original, "[^a-zA-Z-0-9 _-]", "");
        
    }
}
