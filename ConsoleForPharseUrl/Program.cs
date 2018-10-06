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
            var myPlattern = "https://mana.com/app/{app-id}/services/{service-id}";
            var myText = "https://mana.com/nana/di394/services/services/878";

            var builder = new UrlMapper.Implement.SimpleStringParameterBuilder();
            var mypraser = builder.Parse(myPlattern) as SimpleStringParameter;
            foreach(var item in mypraser.keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
