using System;
using System.IO;
using System.Collections.Generic;

namespace CustomDictionaryEditor.Model
{
    /// <summary>
    /// Each word list is written in a .dic file, which is a plain text file
    /// with a single word per line.
    /// </summary>
    class WordListAccessor
    {
        public List<string> OpenWordList(string fileName)
        {
            List<string> dictionary = new List<string>();

            if (File.Exists(fileName) == true)
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        dictionary.Add(s);
                    }
                }
            }
            else
            {
                // Do nothing
            }

            return dictionary;
        }
    }
}
