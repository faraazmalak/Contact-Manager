using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mode
{
    public class Mode
    {

        public enum EditModeEnum
        {

            Rename = 1,
            Normal = 2,
            AddNew = 3,
ExternalEdit=4,
            InternalEdit=5,
            Import=6,


        }

        private EditModeEnum ModeProperty = EditModeEnum.Normal;
        public EditModeEnum EditMode
        {

            get
            {
                return ModeProperty;
            }

            set
            {
                ModeProperty = value;


            }

        }
    }
}
