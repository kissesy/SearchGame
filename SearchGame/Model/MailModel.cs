using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchGame.Model
{
    public class MailModel
    {

    }

    public class ChatList
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Msg;
        public string Msg
        {
            get { return _Msg; }
            set { _Msg = value; }
        }

        private string _Date;
        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public int identity; //인물마다 고유 값 
    }


    public class ContactList
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public int identity; //인물마다 고유 값 

    }

}
