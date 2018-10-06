//using System;
//using Xunit;
//using System.Collections.Generic;
//using UrlMapper.Implement;

//namespace UrlMapper.Tests
//{
//    public class UnitTest1
//    {
//        ISimpleStringParameterBuilder builder;

//        [Fact]
//        public void TestMyImplement()
//        {
//            builder = new SimpleStringParameterBuilder();
//            var resultBuilder = builder.Parse("https://mana.com/linkto/{link-id}");
//            var isMatch = resultBuilder.IsMatched("https://mana.com/linkto/A2348");
//            var mtDic = new Dictionary<string, string>();
//            if(isMatch)
//            {
//                resultBuilder.ExtractVariables("https://mana.com/linkto/A2348", mtDic);
//            }
//            Assert.Equal(mtDic.GetValueOrDefault("{link-id}"),"A2348");
//        }

//        [Theory]
//        [InlineData("https://mana.com/linkto/{link-id}", "{link-id}")]
//        [InlineData("https://mana.com/services/{service-id}", "{service-id}")]
//        public void TestGetOneKey(string text,string key1)
//        {
//            builder = new SimpleStringParameterBuilder();
//            SimpleStringParameter myBuilder = builder.Parse(text) as SimpleStringParameter;
//            Assert.True(myBuilder.keys.Exists(x => x == key1));
//        }

//        [Theory]
//        [InlineData("https://mana.com/linkto/{link-id}", "{link-id}","")]
//        [InlineData("https://mana.com/services/{service-id}", "{service-id}", "")]
//        public void TestGetTwoKey(string text, string key1, string key2)
//        {
//            builder = new SimpleStringParameterBuilder();
//            SimpleStringParameter myBuilder = builder.Parse(text) as SimpleStringParameter;
//            Assert.True(myBuilder.keys.Exists(x => x == key1));
//            Assert.True(myBuilder.keys.Exists(x => x == key2));
//        }

//        [Fact]
//        public void SetPathToCompare()
//        {

//        }
//    }
//}
