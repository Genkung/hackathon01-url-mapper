using System;
using System.Collections.Generic;
using UrlMapper;

namespace UrlMapper.Implement
{
    public class SimpleStringParameterBuilder: ISimpleStringParameterBuilder
    {
        List<string> keys;

        public ISimpleStringParameter Parse(string pattern)
        {
            return new SimpleStringParameter(pattern);
        }
    }
}
