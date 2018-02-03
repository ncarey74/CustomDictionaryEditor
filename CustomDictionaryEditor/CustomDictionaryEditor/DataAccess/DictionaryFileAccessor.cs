using System;
using System.IO;

namespace CustomDictionaryEditor.DataAccess
{
    class DictionaryFileAccessor
    {
        private void openFile()
        {
            string path = @"C:\Users\Carey\AppData\Roaming\Microsoft\UProof\ExampleDict.dic";
            if (File.Exists(path) == true)
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                // Do nothing
            }
        }
    }
}
