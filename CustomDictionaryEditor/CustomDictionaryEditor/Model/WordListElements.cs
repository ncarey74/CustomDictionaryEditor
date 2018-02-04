using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionaryEditor.Model
{
    /// <summary>
    /// 
    /// </summary>
    public enum WordListValidity
    {
        Invalid = 0,
        Valid = 1
    }

    class WordListElements
    {
        WordListValidity _isValidWordListFile;
        string _wordListName;
        List<string> _words;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validity"></param>
        /// <param name="wordListName"></param>
        /// <param name="words"></param>
        public WordListElements(WordListValidity validity, string wordListName, List<string> words)
        {
            _isValidWordListFile = validity;
            _wordListName = wordListName;
            _words = words;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public WordListValidity IsValidWordList()
        {
            return _isValidWordListFile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string WordListName()
        {
            if (_isValidWordListFile == WordListValidity.Valid)
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
            if (_isValidWordListFile == WordListValidity.Valid)
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
