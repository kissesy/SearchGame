using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchGame.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SearchGame.ViewModel;
using System.Messaging;
using System.Windows;

namespace SearchGame.ViewModel
{
    public class SocialViewModel : INotify, IMessageBoxService
    {

        #region MessageBox
        //MessageBox Interface 
        bool ShowMessage(string text, string caption, MessageType messageType)
        {
            MessageBox.Show(text, caption, MessageBoxButton.OK, MessageBoxImage.Information);
            return true;
        }

        bool IMessageBoxService.ShowMessage(string text, string caption, MessageType messageType)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
