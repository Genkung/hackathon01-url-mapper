using System;
using System.Collections.Generic;
using UrlMapper;

namespace UrlMapper.Implement
{
    public class SimpleStringParameter : ISimpleStringParameter
    {
        public List<string> keys;
        public List<string> pathToCompare;

        public SimpleStringParameter(string pattern)
        {
            SetPathToCompare(pattern);
            SetKeys(pattern);
        }

        public bool IsMatched(string textToCompare)
        {
             throw new System.NotImplementedException();
        }

        public void ExtractVariables(string target, IDictionary<string, string> dicToStoreResults)
        {
            throw new System.NotImplementedException();
        }

        public void SetKeys(string pattern)
        {
            
        }
        
        public void SetPathToCompare(string pattern)
        {

        }
    }
}