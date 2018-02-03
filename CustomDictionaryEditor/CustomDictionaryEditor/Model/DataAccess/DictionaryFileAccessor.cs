using System;
using System.IO;
using System.Collections.Generic;

namespace CustomDictionaryEditor.Model.DataAccess
{
    class DictionaryFileAccessor
    {
        public List<string> OpenFile()
        {
            List<string> dictionary = new List<string>();
            string path = @"C:\Users\Carey\AppData\Roaming\Microsoft\UProof\ExampleDict.dic";

            if (File.Exists(path) == true)
            {
                using (StreamReader sr = File.OpenText(path))
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
