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


        #region Constructor
        public SocialViewModel()
        {
            OnSwitch("OnSearch");
        }
        #endregion

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
                new SocialUrlList { ProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png", ProfileName = "김아무개(@youngMan3221)", indentity=1},
                new SocialUrlList { ProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png", ProfileName = "김무슨갓(@tuunakd)", indentity=2 },
                new SocialUrlList { ProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png", ProfileName = "이세현(@goodia123)", indentity=3 }
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

        private bool _OnSearch;
        public bool OnSearch
        {
            get { return _OnSearch; }
            set { _OnSearch = value; RaisePropertyChanged("OnSearch"); }
        }

        private bool _OnUser;
        public bool OnUser
        {
            get { return _OnUser; }
            set { _OnUser = value; RaisePropertyChanged("OnUser"); }
        }

        void OnSwitch(string thing)
        {
            OnSearch = ("OnSearch" == thing) ? true : false;
            OnUser = ("OnUser" == thing) ? true : false;
        }
        #endregion

        #region LoadUserTwit


        string _UserImage;
        public string UserImage
        { 
            get { return _UserImage; }
            set { _UserImage = value; RaisePropertyChanged("UserImage"); }
        }


        string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; RaisePropertyChanged("UserName"); }
        }

        ObservableCollection<UserTwitList> _UserTwit = new ObservableCollection<UserTwitList>();
        public ObservableCollection<UserTwitList> UserTwitLists
        {
            get { return _UserTwit; }
            set { _UserTwit = value; RaisePropertyChanged("UserTwitLists"); }
        }

        public string TwitDate;
        public string TwitContent;

        void LoadUserTwit()
        {
            //특정 identity인것만 가지고옴 
            OnSwitch("OnUser");
            UserName = SelectedUrl.ProfileName;
            UserImage = SelectedUrl.ProfileImage;

            ObservableCollection<UserTwitList> Twits = new ObservableCollection<UserTwitList>
            {
                new UserTwitList { TwitDate = "2020-12.21", TwitContent = "밥 잘묵음" },
                new UserTwitList { TwitDate = "2020-12.22", TwitContent = "밥 잘 안묵음" },
                new UserTwitList { TwitDate = "2020-12.24", TwitContent = "밥 많이묵음" }
            };
            UserTwitLists = Twits;
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
            //identity 체크 
            
            LoadUserTwit();
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
