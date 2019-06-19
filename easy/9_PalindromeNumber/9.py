# https://leetcode.com/problems/palindrome-number/
class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x <= 0:
            return False

        s = []
        while x > 0:
            r = x % 10
            x = int(x/10)
            s.append(r)

        for i in range(len(s)):
            if s[i] != s[len(s) - i-1]:
                return False

        return True


ss = Solution()
print(ss.isPalindrome(12))
