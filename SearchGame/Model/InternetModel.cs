using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchGame.Model
{
    public class InternetModel
    {
       
    }

    public class NewsTemplate
    {
        private string newscompany;
        private string newstitle;
        private string newscontent;


        public string NewsCompnay
        {
            get { return newscompany; }
            set { newscompany = value; }
        }

        public string NewsTitle
        {
            get { return newstitle; }
            set { newstitle = value; }
        }
        public string NewsContent
        {
            get { return newscontent; }
            set { newscontent = value; }
        }
    }

    public class BlogTemplate
    {
        private string _BlogProfileImage;
        private string _BlogProfileName;

        private string _BlogTitle;
        private string _BlogDate;
        private string _BlogContent;

        public string BlogProfileImage
        {
            get { return _BlogProfileImage; }
            set { _BlogProfileImage = value; }
        }
        public string BlogProfileName
        {
            get { return _BlogProfileName; }
            set { _BlogProfileName = value; }
        }
        public string BlogTitle
        {
            get { return _BlogTitle; }
            set { _BlogTitle = value; }
        }
        public string BlogDate
        {
            get { return _BlogDate; }
            set { _BlogDate = value; }
        }
        public string BlogContent
        {
            get { return _BlogContent; }
            set { _BlogContent = value; }
        }

        public int identity;
    }



    public class UrlList
    {
        private string urltitle;
        private string urlcontent;
        private string urldate;
        

        public string UrlTitle
        {
            get { return urltitle; }
            set { urltitle = value; }
        }

        public string UrlContent
        {
            get { return urlcontent; }
            set { urlcontent = value; }
        }

        public string UrlDate
        {
            get { return urldate; }
            set { urldate = value; }
        }

        public int Type; //타입에 따라 각 어떤 템플릿이 나올지 결정됨 
        public int identity; //타입에 따른 식별코드
    }
}
