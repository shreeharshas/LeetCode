/*
 
 Decrypt Message

An infamous gang of cyber criminals named “The Gray Cyber Mob”, which is behind many hacking attacks and drug trafficking, has recently become a target for the FBI. After intercepting some of their messages, which looked like complete nonsense, the agency learned that they indeed encrypt their messages, and studied their method of encryption.

Their messages consist of lowercase latin letters only, and every word is encrypted separately as follows:

Convert every letter to its ASCII value. Add 1 to the first letter, and then for every letter from the second one to the last one, add the value of the previous letter. Subtract 26 from every letter until it is in the range of lowercase letters a-z in ASCII. Convert the values back to letters.

For instance, to encrypt the word “crime”

Decrypted message:	c	r	i	m	e
Step 1:	99	114	105	109	101
Step 2:	100	214	319	428	529
Step 3:	100	110	111	116	113
Encrypted message:	d	n	o	t	q
The FBI needs an efficient method to decrypt messages. Write a function named decrypt(word) that receives a string that consists of small latin letters only, and returns the decrypted word.

Explain your solution and analyze its time and space complexities.

Examples:

input:  word = "dnotq"
output: "crime"

input:  word = "flgxswdliefy"
output: "encyclopedia"
Since the function should be used on messages with many words, make sure the function is as efficient as possible in both time and space. Explain the correctness of your function, and analyze its asymptotic runtime and space complexity.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomDecoder
{
    class Program
    {
        public static string Decrypt(string word)
        {
            int[] decrypted = new int[word.Length];
            decrypted[0] = ((int)word[0]);

            for (int i = 1; i < word.Length; i++)
                decrypted[i] = (int)word[i];

            for (int i = word.Length - 1; i > 0; i--)
            {
                decrypted[i] -= decrypted[i - 1];

                while (decrypted[i] < 97)
                    decrypted[i] += 26;
            }

            decrypted[0]--;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < decrypted.Length; i++)
            {
                sb.Append((char)decrypted[i]);
            }
            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Decrypt("dnotq"));
            Console.WriteLine(Decrypt("flgxswdliefy"));
            Console.ReadKey();
        }
    }
}
