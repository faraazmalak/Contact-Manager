using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace DazzleDesign_Contact_Reader
{
  [Serializable]  class Contact
    {
        private Point LocationProperty;
        public Point Location{

            get {
                return LocationProperty;
            
            }

            set {
                LocationProperty = value;
            }
        
        }


        private System.Collections.Generic.Dictionary<string,object> DetailsProperty=new Dictionary<string,object>() ;
        public System.Collections.Generic.Dictionary<string,object> Details
        {

            get
            {
                return DetailsProperty;
             
            }

            set
            {
                DetailsProperty = value;
            }

        }

        private System.Collections.Specialized.StringCollection EmailsProperty = new System.Collections.Specialized.StringCollection();
        public System.Collections.Specialized.StringCollection Emails
        {

            get
            {
                return EmailsProperty;

            }

            set
            {
               EmailsProperty = value;
            }

        }

        private Image PictureProperty = Properties.Resources.UserIcon;
        public Image Picture
        {

            get
            {
                return PictureProperty;

            }

            set
            {
               PictureProperty = value;
            }

        }


        private string AppVersionProperty;
        public string AppVersion
        {

            get
            {
                return AppVersionProperty;
            }

            set
            {
                AppVersionProperty = value;

            }



        }


    }
}
