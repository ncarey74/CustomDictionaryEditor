using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomDictionaryEditor.Utilities;

namespace CustomDictionaryEditor.Model
{
    class WordListModel : PropertyBase
    {
        #region Properties

        private string _WordListName;
        public string WordListName
        {
            get
            {
                return _WordListName;
            }
            set
            {
                if (_WordListName != value)
                {
                    _WordListName = value;
                    RaisePropertyChanged(WordListName);
                }
            }
        }

        private List<string> _WordList;
        public List<string> WordList
        {
            get
            {
                return _WordList;
            }
            set
            {
                if (_WordList != value)
                {
                    _WordList = value;
                    RaisePropertyChanged("WordList");
                }
            }
        }

        #endregion 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="words"></param>
        public WordListModel(string name, List<string> words)
        {
            _WordListName = name;
            _WordList = words;
        }
    }
}
