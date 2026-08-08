var sol = new Solution();
var result = sol.IsPalindrome("A man, a plan, a canal: Panama");

Console.Write($"result: {result}");

public class Solution {
    public bool IsPalindrome(string s) {
        var right = s.Length - 1;
        var left = 0;
        while (left < right)
        {
            var isLeftLetter = char.IsLetterOrDigit(s[left]);
            var isRightLetter = char.IsLetterOrDigit(s[right]);
            
            if (!isLeftLetter)
            {
                left++;
                continue;
            }

            if (!isRightLetter)
            {
                right--;
                continue;
            }
            
            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
            {
                return false;
            }
            right--;
            left++;
        }
        return true;
    }
}