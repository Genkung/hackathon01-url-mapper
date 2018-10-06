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
            //var myPlattern = "something/aa{p1-no-data}bb/xx{p2-with-prefix}";
            //var myText = "something/aabb/xxthes";

            var myPlattern = "www.something.org/{p1}/{p2}/";
            var myText = "www.something.org/1/2/";

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
