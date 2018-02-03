using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionaryEditor.Model
{
    class WordListElements
    {
        bool _isValidWordListFile = false;
        string _wordListName = "Empty";
        List<string> _words = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isValidWordListFile"></param>
        /// <param name="wordListName"></param>
        /// <param name="words"></param>
        public WordListElements(bool isValidWordListFile, string wordListName, List<string> words)
        {
            _isValidWordListFile = isValidWordListFile;
            _wordListName = wordListName;
            _words = words;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsValidWordList()
        {
            return _isValidWordListFile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string WordListName()
        {
            if (_isValidWordListFile == true)
            {
                return _wordListName;
            }
            else
            {
                throw new System.InvalidOperationException("Cannot return word list name. Word list is not valid.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> Words()
        {
            if (_isValidWordListFile == true)
            {
                return _words;
            }
            else
            {
                throw new System.InvalidOperationException("Cannot return word list. Word list is not valid.");
            }
        }
    }
}
