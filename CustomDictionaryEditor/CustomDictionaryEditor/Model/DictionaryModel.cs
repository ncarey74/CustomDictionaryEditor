using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomDictionaryEditor.Utilities;

namespace CustomDictionaryEditor.Model
{
    class DictionaryModel : PropertyBase
    {
        #region Properties

        private List<WordListModel> _WordLists;
        public List<WordListModel> WordLists
        {
            get
            {
                return _WordLists;
            }
            set
            {
                if (_WordLists != value)
                {
                    _WordLists = value;
                    RaisePropertyChanged("WordLists");
                }
            }
        }

        #endregion

        public DictionaryModel()
        {
            var d = new DictionaryAccessor();
            _WordLists = d.OpenDictionary();
        }
    }
}
