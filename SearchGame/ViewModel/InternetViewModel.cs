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
    public class InternetViewModel : INotify, IMessageBoxService
    {
        public InternetViewModel()
        {
            //ContentView = new ViewModel.InternetViewModel();
            OnView("OnBrowser");
        }

        private Object contentview;
        public Object ContentView
        {
            get { return contentview; }
            set
            {
                contentview = value;
                RaisePropertyChanged("ContentView");
            }
        }

        #region ON/OFF 
        private bool _OnBrowser;
        public bool OnBrowser
        {
            get { return _OnBrowser; }
            set
            {
                _OnBrowser = value;
                RaisePropertyChanged("OnBrowser");
            }
        }

        private bool _OnNews;
        public bool OnNews
        {
            get { return _OnNews; }
            set
            {
                _OnNews = value;
                RaisePropertyChanged("OnNews");
            }
        }

        private bool _OnBlog;
        public bool OnBlog
        {
            get { return _OnBlog; }
            set
            {
                _OnBlog = value;
                RaisePropertyChanged("OnBlog");
            }
        }


        void OnView(string thing)
        {
            OnBrowser = (thing == "OnBrowser") ? true : false;
            OnNews = (thing == "OnNews") ? true : false;
            OnBlog = (thing == "OnBlog") ? true : false;
        }
        #endregion

        #region CloseInternetView

        void CloseInternetExecute()
        {
            //ShowMessage("asd", "asd", MessageType.Acknowledgment);
            //ViewModel 할당은됨 
            ContentView = new HomeViewModel();
        }

        bool CanCloseInternetExecute()
        {
            return true;
        }

        public ICommand CloseInternet { get { return new RelayCommand(CloseInternetExecute, CanCloseInternetExecute); } }
        #endregion

        #region Search
        private string searchcontent;
        public string SearchContent
        {
            get { return searchcontent; }
            set { searchcontent = value; }
        }

        void SearchExecute()
        {
            //현재 켜져있는 모든 창 hidden상태로 넣기 
            //OnNews = false;
            //OnBrowser = true;
            //OnBlog = false;
            OnView("OnBrowser");
            LoadUrls();
        }

        bool CanSearchExecute()
        {
            if (SearchContent != string.Empty) return true;
            else return false;
            //나중에 Button disable/enable로 변경하기
        }

        public ICommand Search { get { return new RelayCommand(SearchExecute, CanSearchExecute); } }
        #endregion

        #region ClickURL

        private UrlList _Url;
        public UrlList SelectedUrl
        {
            get { return _Url; }
            set { _Url = value; RaisePropertyChanged("SelctedUrl"); }
        }


        //해당 URL클릭시 type과 식별코드로 알맞은 뉴스템플렛 생성
        void ClickUrlExecute()
        {
            
            //OnBrowser = false; //클릭된 객체의 타입에 따라 어떤 것들을 false로 할지 결정
            if(SelectedUrl.Type == 1)
            {
                OnView("OnNews");
                //OnBlog = false;
                //OnNews = true;
                LoadNews();
            }
            else if(SelectedUrl.Type == 2)
            {
                //OnBlog = true;
                //OnNews = false;
                OnView("OnBlog");
                LoadBlog();
            }  
        }

        bool CanClickUrlExecute()
        {
            return SelectedUrl != null;
        }

        public ICommand ClickUrl { get { return new RelayCommand(ClickUrlExecute, CanClickUrlExecute); } }


        #endregion

        #region NewsTemplate

        private NewsTemplate _News = new NewsTemplate();
        public NewsTemplate News
        {
            get { return _News; }
            set 
            {
                _News = value;
                RaisePropertyChanged("NewsCompany");
                RaisePropertyChanged("NewsTitle");
                RaisePropertyChanged("NewsContent");
            }
        }

        public string NewsCompany
        {
            get { return News.NewsCompnay; }
            set { News.NewsCompnay = value; }
        }

        public string NewsTitle
        {
            get { return News.NewsTitle; }
            set { News.NewsTitle = value; }
        }
        public string NewsContent
        {
            get { return News.NewsContent; }
            set { News.NewsContent = value; }
        }



        void LoadNews()
        {
            NewsTemplate news = new NewsTemplate();
            news.NewsCompnay = "A 뉴스";
            news.NewsTitle = "충격 실화";
            news.NewsContent = "조사 결과 사실로 밝혀졌습니다.";
            //뉴스 객체 생성
            News = news;
        }

        #endregion


        #region BlogTemplate

        private BlogTemplate _Blog;
        public BlogTemplate Blog
        {
            get { return _Blog; }
            set
            {
                _Blog = value;
                RaisePropertyChanged("BlogProfileImage");
                RaisePropertyChanged("BlogProfileName");
                RaisePropertyChanged("BlogTitle");
                RaisePropertyChanged("BlogDate");
                RaisePropertyChanged("BlogContent");
            }
        }

        public string BlogProfileImage
        {
            get { return Blog.BlogProfileImage; }
            set { Blog.BlogProfileImage = value; }
        }
        public string BlogProfileName
        {
            get { return Blog.BlogProfileName; }
            set { Blog.BlogProfileName = value; }
        }
        public string BlogTitle
        {
            get { return Blog.BlogTitle; }
            set { Blog.BlogTitle = value; }
        }
        public string BlogDate
        {
            get { return Blog.BlogDate; }
            set { Blog.BlogDate = value; }
        }
        public string BlogContent
        {
            get { return Blog.BlogContent; }
            set { Blog.BlogContent = value; }
        }

        //추후에 인자로 선태한 SelectedUrl 객체받기
        void LoadBlog()
        {
            //Identity에 따라 ~~ 
            BlogTemplate Blogs = new BlogTemplate();
            Blogs.BlogProfileImage = "C:/Users/tuuna/Desktop/Search/Image/person.png";
            Blogs.BlogProfileName = "김아무개";
            Blogs.BlogTitle = "승우형이 해주기를 기대중";
            Blogs.BlogDate = "2019-12-28";
            Blogs.BlogContent = "볼리베어 양학중 사실로 밝혀졌습니다.";
            Blog = Blogs;
        }

        #endregion

        #region UrlList

        private ObservableCollection<UrlList> Urls = new ObservableCollection<UrlList>();
        public ObservableCollection<UrlList> UrlLists
        {
            get { return Urls; }
            set { Urls = value;  RaisePropertyChanged("UrlLists"); }
        }

        void LoadUrls()
        {
            ObservableCollection<UrlList> _Urls = new ObservableCollection<UrlList>();
            _Urls.Add(new UrlList
            {
                UrlTitle = "이것은 제목입니다.",
                UrlContent = "이것은 컨텐츠입니다.",
                UrlDate = "2020-06-08",
                Type = 1,
                identity = 1
            });
            _Urls.Add(new UrlList
            {
                UrlTitle = "이것은 제목입니다.",
                UrlContent = "이것은 컨텐츠입니다.",
                UrlDate = "2020-06-08",
                Type = 2,
                identity = 2,
            });
            _Urls.Add(new UrlList
            {
                UrlTitle = "이것은 제목입니다.",
                UrlContent = "이것은 컨텐츠입니다.",
                UrlDate = "2020-06-08",
                Type = 3,
                identity = 1
            });
            UrlLists = _Urls;
        }

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
