using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ArabicUnshapingLib
{
    public static class Unshaper
    {
        public static string GetAsUnicode(this string shapedText)
        {
            shapedText = Regex.Unescape(shapedText.Trim());
            var words = shapedText.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    string shapedUnicode = @"\u" + ((int)word[i]).ToString("X4");
                    builder.Append(shapedUnicode);
                }
            }
            return builder.ToString();
        }

        public static string GetUnShapedUnicode(this string original)
        {
            //remove escape characters
            original = Regex.Unescape(original.Trim());

            var words = original.Split(' ');
            StringBuilder builder = new StringBuilder();
            var unicodeTable = UnicodeTable.GetArabicGlyphs();
            foreach (var word in words)
            {
                string previous = null;
                int index = 0;
                foreach (var character in word)
                {
                    string shapedUnicode = @"\u" + ((int)character).ToString("X4");

                    //if unicode doesn't exist in unicode table then character isn't a letter hence shaped unicode is fine
                    if (!unicodeTable.ContainsKey(shapedUnicode))
                    {
                        builder.Append(shapedUnicode);
                        previous = null;
                        continue;
                    }
                    else
                    {
                        //first character in word or previous character isn't a letter
                        if (index == 0 || previous == null)
                        {
                            builder.Append(unicodeTable[shapedUnicode][1]);
                        }
                        else
                        {
                            bool previousCharHasOnlyTwoCases = unicodeTable[previous][4] == "2";
                            //if last character in word
                            if (index == word.Length - 1)
                            {
                                if (!string.IsNullOrEmpty(previous) && previousCharHasOnlyTwoCases)
                                {
                                    builder.Append(unicodeTable[shapedUnicode][0]);
                                }
                                else
                                    builder.Append(unicodeTable[shapedUnicode][3]);
                            }
                            else
                            {
                                if (previousCharHasOnlyTwoCases)
                                    builder.Append(unicodeTable[shapedUnicode][1]);
                                else
                                    builder.Append(unicodeTable[shapedUnicode][2]);
                            }
                        }
                    }

                    previous = shapedUnicode;
                    index++;
                }
                //if not last word then add a space unicode
                if (words.ToList().IndexOf(word) != words.Length - 1)
                    builder.Append(@"\u" + ((int)' ').ToString("X4"));
            }

            return builder.ToString();
        }
        public static string DecodeEncodedNonAsciiCharacters(this string value)
        {
            return Regex.Replace(
                value,
                @"\\u(?<Value>[a-zA-Z0-9]{4})",
                m => ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString());
        }
    }
}
