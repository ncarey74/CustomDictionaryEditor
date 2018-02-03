using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionaryEditor.Model
{
    class DictionaryModel
    {
        private List<WordListModel> wordLists;

        public DictionaryModel()
        {
            var d = new DictionaryAccessor();
            wordLists = d.OpenDictionary();
        }
    }
}
