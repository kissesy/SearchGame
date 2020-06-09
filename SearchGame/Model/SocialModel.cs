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


    }

}
