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
                    WordListElements wordListElements = fileAccessor.OpenWordList(fileName);

                    if (wordListElements.IsValidWordList() == true)
                    {
                        wordLists.Add(new WordListModel(wordListElements.WordListName(),
                                                        wordListElements.Words()));
                    }
                    else
                    {
                        // Do nothing.
                    }
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
