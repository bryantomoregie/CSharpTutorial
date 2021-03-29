using System;
using System.Collections.Generic;

namespace CSharpTutorial.AlgoExper
{
    public class DocumentChecker
    {
        public static bool GenerateDocument(string characters, string document)
        {


            Dictionary<char, int> dict1 = CreateDictionary(document);
            Dictionary<char, int> dict2 = CreateDictionary(characters);

            foreach (var entry in dict1)
            {
                if (!dict2.ContainsKey(entry.Key) || dict2[entry.Key] < dict1[entry.Key])
                {
                    return false;
                }
            }
            return true;
        }

        public static Dictionary<char, int> CreateDictionary(string characters)
        {
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            foreach (var key in characters)
            {
                if (dict1.ContainsKey(key))
                {
                    dict1[key] = dict1[key] + 1;
                }
                else
                {
                    dict1.Add(key, 1);
                }
            }
            return dict1;
        }
    }
}
