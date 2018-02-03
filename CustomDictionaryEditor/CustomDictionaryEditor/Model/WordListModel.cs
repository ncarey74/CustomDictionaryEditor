using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CustomDictionaryEditor.Model
{
    class WordListModel
    {
        private List<string> _words;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public WordListModel(List<string> words)
        {
            _words = words;
            foreach (var word in _words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
