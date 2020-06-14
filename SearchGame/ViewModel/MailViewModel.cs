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
    public class MailViewModel : INotify
    {
        private ObservableCollection<ContactList> _ContactLists = new ObservableCollection<ContactList>();
        public ObservableCollection<ContactList> ContactLists
        {
            get { return _ContactLists; }
            set { _ContactLists = value; RaisePropertyChanged("ContactLists"); }
        }


        public MailViewModel()
        {
            LoadContactList();  
        }

        void LoadContactList()
        {
            ObservableCollection<ContactList> Contacts = new ObservableCollection<ContactList>
            {
                new ContactList { Name = "A기자", Email = "b132@naver.com", identity=1 },
                new ContactList { Name = "B기자", Email = "c1332312@naver.com", identity=2 },
                new ContactList { Name = "C기자", Email = "A1232132@naver.com", identity=3 }
            };

            ContactLists = Contacts;
        }


        #region ClickContact & sendMsg

        private ContactList _SelectedContact;
        public ContactList SelectedContact
        {
            get { return _SelectedContact; }
            set { _SelectedContact = value; }
        }

        void AddMsg()
        {
            ChatLists.Add(new ChatList { Name = "김아무개", Msg = "밥먹었나요!!!!!", Date = "2019-12-13 13:12:04" });
        }

        void SendMsgExecute()
        {
            //add msg //해당 사람과 대화중일때만 입력 가능
            if (SelectedContact == null) return;
            else AddMsg();
            
        }

        bool CanSendMsgExecute()
        {
            return true;
        }

        public ICommand SendMsg { get { return new RelayCommand(SendMsgExecute, CanSendMsgExecute); } }

        private ObservableCollection<ChatList> _ChatLists = new ObservableCollection<ChatList>();
        public ObservableCollection<ChatList> ChatLists
        {
            get { return _ChatLists; }
            set { _ChatLists = value; RaisePropertyChanged("ChatLists"); }
        }

        void LoadContactMsg()
        {
            int identity = SelectedContact.identity; //해당 identity로 어떤 대화를 불러올것인지 체크

            ObservableCollection<ChatList> Chats = new ObservableCollection<ChatList>();
            Chats.Add(new ChatList { Name="김아무개", Msg="밥먹었나요", Date="2019-12-13 13:12:02"});
            Chats.Add(new ChatList { Name = "김아무개", Msg = "밥먹었나요!!", Date = "2019-12-13 13:12:03" });
            Chats.Add(new ChatList { Name = "김아무개", Msg = "밥먹었나요!!!!!", Date = "2019-12-13 13:12:04" });

            ChatLists = Chats;
        }

        
        void ClickContactExecute()
        {
            LoadContactMsg();
            //if (SelectedContact != null) return;
            //else LoadContactMsg();

        }

        bool CanClickContactExecute()
        {
            //return true;
           return SelectedContact != null;
        }

        public ICommand ClickContact { get { return new RelayCommand(ClickContactExecute, CanClickContactExecute); } }
        #endregion

        #region CloseView
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

        void CloseMailExecute()
        {
            ContentView = new HomeViewModel();
        }

        bool CanCloseMailExecute()
        {
            return true;
        }

        public ICommand CloseMail { get { return new RelayCommand(CloseMailExecute, CanCloseMailExecute); } }
        #endregion
    }
}
