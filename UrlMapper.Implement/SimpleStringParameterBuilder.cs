using System;
using System.Collections.Generic;
using UrlMapper;

namespace UrlMapper.Implement
{
    public class SimpleStringParameterBuilder: ISimpleStringParameterBuilder
    {
        public ISimpleStringParameter Parse(string pattern)
        {
            return new SimpleStringParameter(pattern);
        }
    }
}
