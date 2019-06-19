<b>Question:</b>
Remove duplicate adjacent chars in a given string

Make abbaca --> ca

<b>Solving by hand:</b>

Step 1: abbaca --> aaca

Step 2: aaca --> ca


<b>Solving by code:</b>

<b>Data Structure:</b> Stack

<b>Algorithm: </b>

Use a stack and keep adding/removing characters

Add character from input string if stack top is not the same

Remove character from stack top if same

After exhausting through the input, the stack will contain unique characters in reverse order

Return stack contents (automatically reversed due to LIFO by design)

<b>Asymptotic Analysis:</b>

In the worst case, the input string has all unique characters

Time Complexity: O(n) where n is the length of input string

Space Complexity: O(n) where n is the length of input string
