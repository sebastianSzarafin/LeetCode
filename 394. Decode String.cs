https://leetcode.com/problems/decode-string/?envType=study-plan&id=level-1

public class Solution {
    public string Decode(string s)
    {
        if(s.IndexOf("[") == -1 && s.IndexOf("]") == -1)
        {
            return s;
        }

        string toAppend = "";
        int i = 0, start = s.IndexOf("[", i);
        while (start != -1)
        {
            while(Char.IsLetter(s[i]))
            {
                toAppend += s[i];
                i++;
            }
            int multiplier = Int32.Parse(s.Substring(i, start - i));
            i = start + 1;
            int openBrackets = 1, closeBrackets = 0;
            while (openBrackets != closeBrackets)
            {
                if (s[i] == '[') openBrackets++;
                if (s[i] == ']') closeBrackets++;
                i++;
            }
            string temp = string.Concat(
                Enumerable.Repeat(
                    Decode(
                        s.Substring(start + 1, i - 1 - (start + 1))), multiplier));
            toAppend = toAppend + temp;
            start = s.IndexOf("[", i);
        }

        while (i < s.Length)
        {
            toAppend += s[i];
            i++;
        }

        return toAppend;
    }
    
    public string DecodeString(string s) {
        return Decode(s);
    }
}
