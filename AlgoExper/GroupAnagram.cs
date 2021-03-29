using System;
using System.Collections.Generic;

namespace CSharpTutorial.AlgoExper
{
    public class GroupAnagram
    {
		public static List<List<string>> groupAnagrams(List<string> words)
		{
			List<List<string>> returnList = new List<List<string>>();
			int i = 0;
			int pointer = 1;
			List<string> list = new List<string>();

			while (i < words.Count - 1)
			{
				
				if (pointer == words.Count)
				{
					list.Add(words[i]);
					returnList.Add(list);
					list.Clear();
					i++;
					pointer = i + 1;
				}

				if (words[i].Length == words[pointer].Length)
				{
					var isAnagram = checkAnagram(words[i], words[pointer]);
				
					if (isAnagram)
					{
						list.Add(words[pointer]);
						words.RemoveAt(pointer);
						pointer--;
					}
				}

				pointer++;
			}
			list.Add(words[i]);
			returnList.Add(list);
			return returnList;
		}

		public static bool checkAnagram(string firstString, string secondString)
		{
			var firstDict = makeDictionary(firstString);
			var secondDict = makeDictionary(secondString);

			foreach (var entry in firstDict)
			{
				if (!secondDict.ContainsKey(entry.Key) || secondDict[entry.Key] != firstDict[entry.Key])
				{
					return false;
				}
			}

			return true;

		}

		public static Dictionary<char, int> makeDictionary(string characters)
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

/*list isnt working, and I should remove the strings from the list once they are added to list*/