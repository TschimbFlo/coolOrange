using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            bool ret = true;
            if (s.Length <= 1)
            {
                ret = true;
            }
            else if (s[0] != s[s.Length - 1])
            {
                ret = false;
            }
            else
            { 
                ret = IsPalindrome(s.Substring(1, s.Length - 2));
            }
            return ret;
        }
    }
}
