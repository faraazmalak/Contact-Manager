using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataRW
{
    [Serializable]
      class ContactDatabaseStructure
    {
        private string XMLDataProperty;
        public string XMLData
        {

            get
            {
                return XMLDataProperty;
            }

            set
            {
                XMLDataProperty = value;

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
