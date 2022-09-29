https://leetcode.com/problems/bulls-and-cows/

public class Solution {
    public string GetHint(string secret, string guess) {
        int bulls = 0, cows = 0;
        StringBuilder _secret = new StringBuilder(secret);
        StringBuilder _guess = new StringBuilder(guess);
        for(int i = 0; i < secret.Length; i++)
        {
            if(secret[i] == guess[i])
            {
                _secret[i] = '-';
                _guess[i] = '-';
                bulls++;
            }
        }
        List<int> secretDigits = new List<int>();
        List<int> guessDigits = new List<int>();
        for(int i = 0; i < secret.Length; i++)
        {
            if(_secret[i] != '-') secretDigits.Add(_secret[i] - '0');
            if(_guess[i] != '-') guessDigits.Add(_guess[i] - '0');
        }
        for(int i = 0; i < secretDigits.Count; i++)
        {
            int i2 = guessDigits.IndexOf(secretDigits[i]);
            if(i2 != -1)
            {
                cows++;
                guessDigits.RemoveAt(i2);
            }
        }
        return bulls.ToString() + "A" + cows.ToString() + "B";
    }
}
