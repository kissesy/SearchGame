using System;
using SearchGame.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Messaging;
using System.Windows;

interface IMessageBoxService
{
    bool ShowMessage(string text, string caption, MessageType messageType);
}

namespace SearchGame.ViewModel
{
    public class HomeViewModel : INotify, IMessageBoxService
    {

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

        public HomeViewModel()
        {
            QuestViewOpen = false;
            //ContentView = new ViewModel.WallPaperViewModel();
            LoadDesktopIcon();
            //LoadQuestListExecute();
        }

        #region OpenIcon

        private DesktopIconList _SelectedIcon;
        public DesktopIconList SelectedIcon
        {
            get { return _SelectedIcon; }
            set { _SelectedIcon = value; RaisePropertyChanged("SelectedIcon"); }
        }

        void OpenIconExecute()
        {
            //어떤 아이콘을 눌렀는지에 대한 정보 필요 
            if(SelectedIcon.Type == 1)
            {
                //InterNetBrowser
                ContentView = new ViewModel.InternetViewModel();
            }
            else if(SelectedIcon.Type == 2)
            {

            }
            else if(SelectedIcon.Type == 3)
            {

            }
            
        }
        bool CanOpenIconExecute()
        {
            return SelectedIcon != null;
        }

        public ICommand OpenIcon { get { return new RelayCommand(OpenIconExecute, CanOpenIconExecute); } }
        #endregion

        #region LoadQuestView

        private QuestDetail _Quest = new QuestDetail();
        public QuestDetail Quest
        {
            get { return _Quest; }
            set
            {
                _Quest = value;
                RaisePropertyChanged("QuestTitle");
                RaisePropertyChanged("QuestContent");
                RaisePropertyChanged("QuestAnswer");
            }
        }

        public string QuestTitle
        {
            get { return Quest.QuestTitle; }
            set { Quest.QuestTitle = value; }
        }

        public string QuestContent
        {
            get { return Quest.QuestContent; }
            set { Quest.QuestContent = value; }
        }
        public string QuestAnswer
        {
            get { return Quest.QuestAnswer; }
            set { Quest.QuestAnswer = value; }
        }

        private bool questviewopen;
        public bool QuestViewOpen
        {
            get { return questviewopen; }
            set
            {
                questviewopen = value;
                RaisePropertyChanged("QuestViewOpen");
            }
        }

        private QuestList selectedquest;
        public QuestList SelectedQuest
        {
            get { return selectedquest; }
            set
            {
                selectedquest = value;
                RaisePropertyChanged("SelectedQuest");
            }
        }

        void LoadQuestViewExecute()
        {
            QuestViewOpen = true;
            QuestDetail _QuestDetail = new QuestDetail();
            //_QuestDetail.QuestTitle = SelectedQuest.QuestName;
            //_QuestDetail.QuestContent = SelectedQuest.QuestContent;
            _QuestDetail.QuestContent = "Quest Content";
            _QuestDetail.QuestTitle = "Quest Title";
            Quest = _QuestDetail;
            //ContentView = new ViewModel.QuestViewModel();
        }

        bool CanLoadQuestViewExecute()
        {
            return true;
        }

        public ICommand LoadQuestView { get { return new RelayCommand(LoadQuestViewExecute, CanLoadQuestViewExecute); } }
        #endregion


        #region LoadDesktopIcon
        ObservableCollection<DesktopIconList> desktopiconlists = new ObservableCollection<DesktopIconList>();
        public ObservableCollection<DesktopIconList> DesktopIconLists
        {
            get { return desktopiconlists; }
            set
            {
                desktopiconlists = value;
                RaisePropertyChanged("DesktopIconList");
            }
        }

        void LoadDesktopIcon()
        {
            //C:/Users/tuuna/Desktop/Search/Image
            ObservableCollection<DesktopIconList> deskiconlist = new ObservableCollection<DesktopIconList>
            {
                new DesktopIconList { ImageName = "Internet", ImageSource = "C:/Users/tuuna/Desktop/Search/Image/internet.png", Type=1 },
                new DesktopIconList { ImageName = "market", ImageSource = "C:/Users/tuuna/Desktop/Search/Image/market.png", Type=2 },
                new DesktopIconList { ImageName = "notepad", ImageSource = "C:/Users/tuuna/Desktop/Search/Image/notepad.png", Type=3 }
            };
            DesktopIconLists = deskiconlist;
        }
        #endregion


        #region LoadQuestList
        ObservableCollection<QuestList> questlists = new ObservableCollection<QuestList>();
        public ObservableCollection<QuestList> QuestLists
        {
            get { return questlists; }
            set
            {
                questlists = value;
                RaisePropertyChanged("QuestLists");
            }
        }

        void LoadQuestListExecute()
        {
            ObservableCollection<QuestList> questlist = new ObservableCollection<QuestList>
            {
                new QuestList { QuestName="코드 짜리", QuestContent="퀘스트내용" }
            };
            QuestLists = questlist;
        }


        bool CanLoadQuestListExecute()
        {
            return true;
        }

        public ICommand LoadQuestList { get { return new RelayCommand(LoadQuestListExecute, CanLoadQuestListExecute); } }
        #endregion

        #region CloseQuestView

        void CloseQuestViewExecute()
        {
            QuestViewOpen = false;
        }

        bool CanCloseQuestViewExecute()
        {
            return true;
        }

        public ICommand CloseQuestView { get { return new RelayCommand(CloseQuestViewExecute, CanCloseQuestViewExecute); } }

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