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
            var myPlattern = "http://hackathon.com";
            var myText = "http://hackathon.com/";

            //var myPlattern = "http://hackathon.com/{username}aa/none";
            //var myText = "http://hackathon.com/test*123/none";

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
