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


        public SocialViewModel()
        {

        }

        #region Search

        private string _SearchContent;
        public string SearchContent
        {
            get { return _SearchContent; }
            set { SearchContent = value; RaisePropertyChanged("SearchContent"); }
        }

        private ObservableCollection<SocialUrlList> Urls = new ObservableCollection<SocialUrlList>();
        public ObservableCollection<SocialUrlList> SocialUrlLists
        {
            get { return Urls; }
            set { Urls = value; RaisePropertyChanged("SocialUrlLists"); }
        }


        void LoadUrl()
        {
            ObservableCollection<SocialUrlList> UrlList = new ObservableCollection<SocialUrlList>
            {
                new SocialUrlList { ProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png", ProfileName = "김아무개" },
                new SocialUrlList { ProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png", ProfileName = "김무슨갓" },
                new SocialUrlList { ProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png", ProfileName = "이세현" }
            };

            SocialUrlLists = UrlList;
        }

        void SearchExecute()
        {
            LoadUrl();
        }

        bool CanSearchExecute()
        {
            return true;
        }

 
        public ICommand Search { get { return new RelayCommand(SearchExecute, CanSearchExecute); } }
        #endregion

        #region On/Off
        void OnSwitch(string thing)
        {

        }
        #endregion

        #region ClickUrl

        private SocialUrlList _SelectedUrl;
        public SocialUrlList SelectedUrl
        {
            get { return _SelectedUrl; }
            set { _SelectedUrl = value; }
        }

        void ClickUrlExecute()
        {

        }

        bool CanClickUrlExecute()
        {
            //return true;
            return SelectedUrl != null;
        }

        public ICommand ClickUrl { get { return new RelayCommand(ClickUrlExecute, CanClickUrlExecute); } }
        #endregion

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
