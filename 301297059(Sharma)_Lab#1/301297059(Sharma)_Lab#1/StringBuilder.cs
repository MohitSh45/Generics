using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301297059_Sharma__Lab_1
{
    public static class StringBuilderExtension
    {
        public static int WordCount(this StringBuilder sb)
        {
            string val = sb.ToString();
            string[] words = val.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
