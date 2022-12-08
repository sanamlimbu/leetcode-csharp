/*
    Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.
    You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.
*/

using System.Text;
public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        string s1 = "";
        string s2 = "";
        if (num1.Length >= num2.Length)
        {
            s1 = num1;
            s2 = num2;
        }
        else
        {
            s1 = num2;
            s2 = num1;
        }

        int offset = s1.Length - s2.Length;
        StringBuilder fill = StringBuilder(s2);
        for (int i = 0; i < offset; i++)
        {
            fill.Insert(0, "0");
        }
        s2 = fill.ToString();

        int carry = 0;
        StringBuilder result = new StringBuilder();
        for (int i = s1.Length - 1; i >= 0; i--)
        {
            // int n1 = (int)char.GetNumericValue(s1[i]);
            // int n2 = (int)char.GetNumericValue(s2[i]);
            int n1 = s1[i] - '0';
            int n2 = s2[i] - '0';
            int sum = n1 + n2 + carry;
            int rem = sum % 10;
            if (rem == 0)
            {
                result.Insert(0, "0");
            }
            else
            {
                result.Insert(0, rem.ToString());
            }
            carry = sum / 10;
        }
        if (carry != 0)
        {
            result.Insert(0, carry.ToString());
        }
        return result.ToString();
    }
}