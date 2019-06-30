class Solution:
    def romanToInt(self, s: str) -> int:
        if (s == None or len(s) == 0):
            return 0

        sw = {'I': 1, 'V': 5, 'X': 10, 'L': 50, 'C': 100, 'D': 500, 'M': 1000}
        l = len(s)

        res = sw[s[l-1]]

        for i in range(l-2, -1, -1):
            if(sw[s[i]] >= sw[s[i+1]]):
                res += sw[s[i]]
            else:
                res -= sw[s[i]]

        return res


s = Solution()
print(s.romanToInt("MCCXXXIV"))
