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
            if (keys == null) return false;
            if (pathToCompare.Count == 0 || pathToCompare == null) return false;
            var preIndex = -2;
            foreach (var path in pathToCompare)
            {
                var index = textToCompare.IndexOf(path);
                if (index > preIndex) { preIndex = index; }
                else { return false; }
            }
            return true;
        }

        public void ExtractVariables(string target, IDictionary<string, string> dicToStoreResults)
        {
            var resultDic = new Dictionary<string, string>();
            var values = target.Split(pathToCompare.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < keys.Count; i++)
            {
                resultDic.Add(keys[i], values[i]);
            }
            dicToStoreResults = resultDic;
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
                    if (keys.Any(x => x == key))
                    {
                        keys = null;
                        return;
                    }
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