using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicetc
{
    public class stringutility
    {
        public static string Summarizetext(string text, int maxlength) {
            if(text.Length<maxlength) { return text; }
            var words = text.Split(' ');
            var Totalcharacters = 0;
            var summaryWords=new List<string>();
            foreach (var word in words) {
             summaryWords.Add(word);
                Totalcharacters += word.Length+1;
               if(Totalcharacters > maxlength) { break; }
            }
            return string.Join(" ", summaryWords)+".....";
    }
    }
}
