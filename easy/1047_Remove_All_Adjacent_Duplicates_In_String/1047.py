class Solution:
    def removeDuplicates(self, S: str) -> str:
        dupRemoved = ["0"]

        for c in S:
            p = dupRemoved[-1]
            if p == c:
                dupRemoved.pop()
            else:
                dupRemoved.append(c)

        if dupRemoved:
            del dupRemoved[0]

        return ''.join(x for x in dupRemoved)


s = Solution()
a = s.removeDuplicates("abbaca")
print(a)
