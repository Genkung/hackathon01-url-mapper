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
            string key;
            do
            {
                key = string.Empty;
                if (pattern.Contains("{") && pattern.Contains("}"))
                {
                    key = pattern.Substring(pattern.IndexOf("{"), pattern.IndexOf("}") - pattern.IndexOf("{") + 1);
                    var splitPattern = pattern.Split(new string[] { key }, StringSplitOptions.None);
                    keys.Add(key);
                    pathToCompare.Add(splitPattern.FirstOrDefault());
                    pattern = splitPattern.LastOrDefault();
                }
                if (string.IsNullOrEmpty(key)) return;
            }
            while (true);
        }
    }
}