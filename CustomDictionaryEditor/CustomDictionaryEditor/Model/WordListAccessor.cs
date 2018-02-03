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
            List<string> words = new List<string>();

            if (File.Exists(fileName) == true)
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        words.Add(s);
                    }
                }
            }
            else
            {
                // Do nothing
            }

            return words;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string FileName(string fileName)
        {
            if (File.Exists(fileName) == true)
            {
                const int fileNameIndex = 0;
            
                string fileNameWithExtension = Path.GetFileName(fileName);
                string[] elements = fileNameWithExtension.Split('.');

                return elements[fileNameIndex];
            }
            else
            {
                return "Not a file!";
            }
        }
    }
}
