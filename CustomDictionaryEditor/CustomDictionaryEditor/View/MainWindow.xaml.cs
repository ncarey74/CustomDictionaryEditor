using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

using CustomDictionaryEditor.ViewModel;

namespace CustomDictionaryEditor
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
       DictionaryFileViewModel _viewModel;
 
       /// <summary>
       /// 
       /// </summary>
      public MainWindow()
      {
         InitializeComponent();
         _viewModel = new DictionaryFileViewModel();
         DataContext = _viewModel;
      }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
      private void btnAddWordList_Click(object sender, RoutedEventArgs e)
      {
          SaveFileDialog saveFileDialog = new SaveFileDialog();
          saveFileDialog.Filter = "Microsoft Office User Dictionary (*.dic)|*.dic";

          if (saveFileDialog.ShowDialog() == true)
          {
              File.WriteAllText(saveFileDialog.FileName, Environment.NewLine);
              _viewModel.Refresh();
          }
      }
   }
}
