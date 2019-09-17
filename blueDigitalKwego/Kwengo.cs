using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blueDigitalKwengo
{
    public class Kwengo
    {

        private static Dictionary<string, char> KwengoMap = new Dictionary<string, char>()
        {
            {"kil",'I'},
            {"jin",'V'},
            {"pol",'X'},
            {"kilow",'L'},
            {"jij",'C'},
            {"jinjin",'D'},
            {"polsx",'M'},
        };

        public static string ConvertKwengoToRoman(string words)
        {
            var strings = words.Split(' ')
                  .Select(c =>
                  {
                      char character;
                      if (!KwengoMap.TryGetValue(c, out character))
                          character = '?';
                      return character;
                  });
            return string.Join("", strings);
        }

    }
}


