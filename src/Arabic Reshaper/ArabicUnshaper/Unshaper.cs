using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ArabicUnshaper
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
            original = Regex.Unescape(original.Trim());
            var words = original.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                string previous = null;
                for (int i = 0; i < word.Length; i++)
                {
                    string shapedUnicode = @"\u" + ((int)word[i]).ToString("X4");
                    if (!UnicodesTable.ARABIC_GLPHIES.ContainsKey(shapedUnicode))
                    {
                        builder.Append(shapedUnicode);
                        previous = null;
                        continue;
                    }
                    else
                    {
                        if (i == 0 || previous == null)
                        {
                            builder.Append(UnicodesTable.ARABIC_GLPHIES[shapedUnicode][1]);
                        }
                        else
                        {
                            if (i == word.Length - 1)
                            {
                                if (!string.IsNullOrEmpty(previous) && UnicodesTable.ARABIC_GLPHIES[previous][4] == "2")
                                {
                                    builder.Append(UnicodesTable.ARABIC_GLPHIES[shapedUnicode][0]);
                                }
                                else
                                    builder.Append(UnicodesTable.ARABIC_GLPHIES[shapedUnicode][3]);
                            }
                            else
                            {
                                bool previouChar = UnicodesTable.ARABIC_GLPHIES[previous][4] == "2";
                                if (previouChar)
                                    builder.Append(UnicodesTable.ARABIC_GLPHIES[shapedUnicode][1]);
                                else
                                    builder.Append(UnicodesTable.ARABIC_GLPHIES[shapedUnicode][2]);
                            }
                        }
                    }

                    previous = shapedUnicode;
                }
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
                m =>
                {
                    return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
                });
        }
    }
}
