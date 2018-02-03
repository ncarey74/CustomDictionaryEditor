using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using CustomDictionaryEditor.Model;
using CustomDictionaryEditor.Utilities;

namespace CustomDictionaryEditor.ViewModel
{
    class DictionaryFileViewModel : PropertyBase
    {
        #region MemberVariables

        private DictionaryModel _dictionary;

        #endregion

        #region Properties

        private ObservableCollection<WordListModel> WordLists { get; set; }

        // Maybe have this as 'WordListModel' instead of 'object'
        private object _SelectedWordList;
        public object SelectedWordList
        {
            get
            {
                return _SelectedWordList;
            }
            set
            {
                if (_SelectedWordList != value)
                {
                    _SelectedWordList = value;
                    RaisePropertyChanged("SelectedWordList");
                }
            }
        }

        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DictionaryFileViewModel()
        {
            WordLists = new ObservableCollection<WordListModel>();
            _dictionary = new DictionaryModel();

            // Add each word list from the internal dictionary to the 
            // WordLists property.
            List<WordListModel> internalWordLists = _dictionary.WordLists;
            internalWordLists.ToList().ForEach(WordLists.Add);
        }
    }
}
