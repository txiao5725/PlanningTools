﻿using Microsoft.Win32;
using System.Windows.Documents;
using System.Windows.Input;
using XerParser.Infrastructure.Commands;
using XerParser.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XerParser.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title = "Planning Tools";

        /// <summary>Window title</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Filename

        private string? _filePath = null;
        public string? FilePath
        {
            get => _filePath;
            set => Set(ref _filePath, value);
        }

        #endregion

        private ObservableCollection<XerParser.Models.Currtype> _currtypes = null;
        public ObservableCollection<XerParser.Models.Currtype> Currtypes
        {
            get => _currtypes;
            set => Set(ref _currtypes, value);
        }


        #region Commands

        #region OpenFileCommand
        public ICommand OpenFileDialogCommand { get; }
        private bool CanOpenFileCommandExecute(object p) => true;
        private void OnOpenFileCommandExecuted(object p)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                var xp = new XerParser.Parse(_filePath);
                Currtypes = xp.currtypesClassList;
            }
        }
        #endregion

        #endregion
        public MainWindowViewModel()
        {
            OpenFileDialogCommand = new RelayCommand(OnOpenFileCommandExecuted, CanOpenFileCommandExecute);
        }
    }
}
