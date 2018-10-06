using System;
using UrlMapper;
using System.Collections.Generic;

namespace ConsoleForPharseUrl
{
    class Program
    {
        static ISimpleStringParameterBuilder pharser;
        static void Main(string[] args)
        {
            pharser = new SimpleStringParameterBuilder();
            var myDic = new Dictionary<string,int>();
            myDic.Add("A",1);
            myDic.Add("B",2);
            Console.WriteLine(myDic.GetValueOrDefault("A"));
            Console.WriteLine(myDic.GetValueOrDefault("C"));
        }
    }
}
