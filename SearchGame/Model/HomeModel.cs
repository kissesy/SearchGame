using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchGame.Model
{
    public class HomeModel
    {
        
    }

    public class DesktopIconList : INotify
    {
        private string imagesource;
        private string imagename;

        public string ImageSource 
        {
            get { return imagesource; }
            set { 
                imagesource = value;
                RaisePropertyChanged("ImageSource");
            }
        }
        public string ImageName
        {
            get { return imagename; }
            set { 
                imagename = value;
                RaisePropertyChanged("ImageName");   
            }
        }

        public int Type;

    }

    public class QuestList : INotify
    {
        private string questname;
        
        public string QuestName 
        {
            get { return questname; }
            set { 
                questname = value;
                RaisePropertyChanged("QuestName");
            }
        }

        private string questcontent;
        public string QuestContent
        {
            get { return questcontent; }
            set
            {
                questcontent = value;
                RaisePropertyChanged("QuestContent");
            }
        }

        public int indentity;
    }

    public class QuestDetail : INotify
    {
        private string questcontent;
        public string QuestContent
        {
            get { return questcontent; }
            set
            {
                questcontent = value;
                RaisePropertyChanged("QuestContent");
            }
        }

        private string questtitle;
        public string QuestTitle
        {
            get { return questtitle; }
            set
            {
                questtitle = value;
                RaisePropertyChanged("QuestTitle");
            }
        }

        private string questanswer;
        public string QuestAnswer 
        {
            get { return questanswer; }
            set
            {
                questanswer = value;
                RaisePropertyChanged("QeuestAnswer");
            }
        }


    }


}
