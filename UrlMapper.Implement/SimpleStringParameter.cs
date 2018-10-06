using System;
using System.Collections.Generic;
using System.Linq;
using UrlMapper;

namespace UrlMapper.Implement
{
    public class SimpleStringParameter : ISimpleStringParameter
    {
        public List<string> keys = new List<string>();
        public List<string> pathToCompare = new List<string>();

        public SimpleStringParameter(string pattern)
        {
            var nextpattern = SetKeys(pattern);
            SetPathToCompare(nextpattern);
        }

        public bool IsMatched(string textToCompare)
        {
            throw new System.NotImplementedException();
        }

        public void ExtractVariables(string target, IDictionary<string, string> dicToStoreResults)
        {
            throw new System.NotImplementedException();
        }

        public string SetKeys(string pattern)
        {
            string key;
            do
            {
                key = string.Empty;
                if (pattern.Contains("{") && pattern.Contains("}"))
                {
                    key = pattern.Substring(pattern.IndexOf("{"), pattern.IndexOf("}") - pattern.IndexOf("{") + 1);
                    pattern = pattern.Remove(pattern.IndexOf("{"), pattern.IndexOf("}") - pattern.IndexOf("{") + 1);
                    keys.Add(key);
                }
                if (string.IsNullOrEmpty(key)) return pattern;
            }
            while (true);
        }

        public void SetPathToCompare(string pattern)
        {

        }

    }
}