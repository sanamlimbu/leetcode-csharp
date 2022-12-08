/*
    Given two binary strings a and b, return their sum as a binary string.
*/
using System.Text;
public class Solution
{
    public string AddBinary(string a, string b)
    {
        string s1 = "";
        string s2 = "";
        if (a.Length >= b.Length)
        {
            s1 = a;
            s2 = b;
        }
        else
        {
            s1 = b;
            s2 = a;
        }

        // fill '0' in front of s2  
        int offset = s1.Length - s2.Length;
        StringBuilder fill = new StringBuilder(s2);
        for (int i = 0; i < offset; i++)
        {
            fill.Insert(0, "0");
        }
        s2 = fill.ToString();

        bool carry = false;
        StringBuilder result = new StringBuilder();

        for (int i = s1.Length - 1; i >= 0; i--)
        {
            char c1 = s1[i];
            char c2 = s2[i];
            if (!carry)
            {
                if (c1 == '1' && c2 == '1')
                {
                    result.Insert(0, "0");
                    carry = true;
                }
                else if (c1 == '0' && c2 == '0')
                {
                    result.Insert(0, "0");
                    carry = false;
                }
                else
                {
                    result.Insert(0, "1");
                    carry = false;
                }
            }
            else
            {
                if (c1 == '1' && c2 == '1')
                {
                    result.Insert(0, "1");
                    carry = true;
                }
                else if (c1 == '0' && c2 == '0')
                {
                    result.Insert(0, "1");
                    carry = false;
                }
                else
                {
                    result.Insert(0, "0");
                    carry = true;
                }
            }
        }
        if (carry)
        {
            result.Insert(0, "1");
        }
        return result.ToString();
    }
}