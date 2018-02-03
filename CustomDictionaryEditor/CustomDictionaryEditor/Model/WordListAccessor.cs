﻿using System;
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
        private WordListValidity _fileValidity = WordListValidity.Invalid;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public WordListElements OpenWordList(string filePath)
        {
            List<string> words = new List<string>();

            if (File.Exists(filePath) == true)
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        words.Add(s);
                    }
                    string name = FileName(filePath);
                    return new WordListElements(_fileValidity, name, words);
                }
            }
            else
            {
                List<string> invalidList = new List<string> { "Invalid word list." };
                return new WordListElements(WordListValidity.Invalid, "Not a file!", invalidList);
            }
        }

        /// <summary>
        /// Returns the name of the file, assuming that it is a valid file. 
        /// 
        /// A valid file is a (1) file that (2) has the 'dic' extension.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>File name.</returns>
        private string FileName(string filePath)
        {
            const int fileNameIndex = 0;
            const int fileExtensionIndex = 1;

            string fileNameWithExtension = Path.GetFileName(filePath);
            string[] elements = fileNameWithExtension.Split('.');

            if (elements[fileExtensionIndex] == "dic")
            {
                _fileValidity = WordListValidity.Valid;
                return elements[fileNameIndex];
            }
            else
            {
                _fileValidity = WordListValidity.Invalid;
                return "Invalid file extension!";
            }
        }
    }
}
