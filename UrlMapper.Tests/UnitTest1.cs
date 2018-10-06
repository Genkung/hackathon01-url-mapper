using System;
using Xunit;
using System.Collections.Generic;

namespace UrlMapper.Tests
{
    public class UnitTest1
    {
        ISimpleStringParameterBuilder builder;

        [Fact]
        public void TestMyImplement()
        {
            builder = new SimpleStringParameterBuilder();
            var resultBuilder = builder.Parse("https://mana.com/linkto/{link-id}");
            var isMatch = resultBuilder.IsMatched("https://mana.com/linkto/A2348");
            var mtDic = new Dictionary<string, string>();
            if(isMatch)
            {
                resultBuilder.ExtractVariables("https://mana.com/linkto/A2348", mtDic);
            }
            Assert.Equal(mtDic.GetValueOrDefault("{link-id}"),"A2348");
        }

        [Fact]
        public void TestSetKeys()
        {
            builder = new SimpleStringParameterBuilder();
            SimpleStringParameter myBuilder = builder.Parse("https://mana.com/linkto/{link-id}");
            var expectedKeys = new List<string>{"{link-id}"};
            var resultKeys = myBuilder.keys;
        }
        [Fact]
        public void SetPathToCompare()
        {

        }
    }
}
