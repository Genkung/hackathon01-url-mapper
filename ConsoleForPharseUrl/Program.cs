using System;
using UrlMapper;
using System.Collections.Generic;
using UrlMapper.Implement;

namespace ConsoleForPharseUrl
{
    class Program
    {
        static ISimpleStringParameterBuilder pharser;
        static void Main(string[] args)
        {
            var myPlattern = "https://mana.com/nana/{app/-id}/services/services/{service-id}";
            var myText = "https://mana.com/nana/Asd/services/services/ZXC";

            var builder = new UrlMapper.Implement.SimpleStringParameterBuilder();
            var mypraser = builder.Parse(myPlattern) as SimpleStringParameter;
            var inMact = mypraser.IsMatched(myText);
            if (inMact)
            {
                var dicResult = new Dictionary<string, string>();
                mypraser.ExtractVariables(myText, dicResult);
            }
            Console.WriteLine(inMact);
        }
    }
}
