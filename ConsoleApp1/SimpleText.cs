using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SimpleText:IStrings
    {
        string text;
        static string[] codeTable =
        {
            "абвгдеёжзийкл",
            "жзийклабвгдеё"
        };

        public SimpleText()
        {
            this.text = "Простой текст!";
        }
        public SimpleText(string text)
        {
            this.text = text;
        }
        public  string Text
        {
            get { return text; }
        }
        string IStrings.Cipher(string[] code)
        {
           string res="";
           foreach(char sym in text)
            {
                int k = code[0].IndexOf(sym);
                if (k > 0) res += code[1][k];
                else res += sym.ToString();
            }
            return res;
        }

        string IStrings.Convert()
        {
            string res="";
            foreach(char sym in text)
            {
                if (sym != ' ') res += sym.ToString();
            }
            res = res.ToLower();
            return res;
        }
    }
}
