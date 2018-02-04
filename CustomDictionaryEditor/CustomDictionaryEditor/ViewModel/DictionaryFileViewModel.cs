﻿using System;
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

        public ObservableCollection<WordListModel> WordLists { get; set; }

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

        #region Commands
        // Edit word list - edit selected word list file
        // New - create new word list file
        // Add - add new word list file
        // Remove - Soft removal by appending _REMOVED to word list file name.

        public RelayCommand AddWordListCommand { get; set; }
        
        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DictionaryFileViewModel()
        {
            WordLists = new ObservableCollection<WordListModel>();
            _dictionary = new DictionaryModel();

            Refresh();
        }

        public void Refresh()
        {
            _dictionary.Refresh();
            WordLists.Clear();

            // Add each word list from the internal dictionary to the 
            // WordLists property.
            List<WordListModel> internalWordLists = _dictionary.WordLists;
            internalWordLists.ToList().ForEach(WordLists.Add);
        }
    }
}
