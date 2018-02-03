using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomDictionaryEditor.Model.DataAccess;

using System.IO;

namespace CustomDictionaryEditor.Model
{
    class DictionaryFileModel
    {
        private List<string> _words;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DictionaryFileModel()
        {
            var _fileAccessor = new DictionaryFileAccessor();
            _words = _fileAccessor.OpenFile();

            foreach (var word in _words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
