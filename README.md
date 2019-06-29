#**C# Arabic Reshaper**

Reconstruct Arabic sentences to be used in some embedded systems where shaped Arabic strings are not supported.

#**Problem**

Let us assume we have the following word:

"سمير" which consists of:

'س' which is written like 'سـ' because it is the first letter in word.

'م' which is written like 'ـمـ' because it is in the middle of word.

'ي' which is written like 'ـيـ' because it is in the middle of word.

'ر' which is written like 'ـر' because it is last letter of word.

if I try convert "سمير" to unicode using something like:
```
public static class StringExtensions
{
    public static string ToUnicodeString(this string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var c in str)
        {
            sb.Append("\\u" + ((int)c).ToString("X4"));
        }
        return sb.ToString();
    }
}
```
The output would be:

\u0633\u0645\u064A\u0631

Which represents { 'س', 'م' , 'ي' , 'ر'} 

instead of 

\uFEB3\uFEE4\uFEF4\uFEAE 

which represnets { 'سـ' , 'ـمـ' , 'ـيـ' , 'ـر'} 

#**Solution:**
