using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchGame.Model
{
    public class SocialModel
    {
    }

    public class UserTwitList
    {
        private string _TwitDate;
        private string _TwitContent;

        public string TwitDate
        {
            get { return _TwitDate; }
            set { _TwitDate = value; }
        }
        public string TwitContent
        {
            get { return _TwitContent; }
            set { _TwitContent = value; }
        }
    }


    public class SocialUrlList
    {
        private string _ProfileImage;
        private string _ProfileName;

        public string ProfileImage
        {
            get { return _ProfileImage; }
            set { _ProfileImage = value; }
        }

        public string ProfileName
        {
            get { return _ProfileName; }
            set { _ProfileName = value; }
        }
        public int indentity;
    }
    

}
