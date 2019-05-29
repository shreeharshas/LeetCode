Question:
Remove duplicate adjacent chars in a given string

Make abbaca --> ca

Solving by hand:

Step 1: abbaca --> aaca

Step 2: aaca --> ca

Solving by code:

Data Structure: Stack

Use a stack and keep adding/removing characters

Add character from input string if stack top is not the same

Remove character from stack top if same

Time Complexity: O(n) where n is the length of input string
Space Complexity: O(n) where n is the length of input string
