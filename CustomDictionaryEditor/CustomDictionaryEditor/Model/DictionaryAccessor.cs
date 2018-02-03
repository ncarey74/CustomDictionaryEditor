using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomDictionaryEditor.Model
{
    class DictionaryAccessor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<WordListModel> OpenDictionary()
        {
            var path = @"C:\Users\Carey\AppData\Roaming\Microsoft\UProof";
            List<WordListModel> wordLists = new List<WordListModel>();

            if (Directory.Exists(path) == true)
            {
                string[] fileEntries = Directory.GetFiles(path);
                var fileAccessor = new WordListAccessor();

                foreach (var fileName in fileEntries)
                {
                    List<string> wordList = fileAccessor.OpenWordList(fileName);
                    var wordListModel = new WordListModel(wordList);
                    wordLists.Add(wordListModel);
                }
            }
            else
            {
                // Do nothing.
            }

            return wordLists;
        }
    }
}
