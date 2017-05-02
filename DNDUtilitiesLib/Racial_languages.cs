using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Racial_languages : DBTable_bridge
    {
        public int race_id
        {
            get;
            private set;
        }

        public int language_id
        {
            get;
            private set;
        }

        internal string FIELD
        {
            get;
            set;
        }

        internal string FIELD_LIST
        {
            get;
            set;
        }

        internal string TABLE
        {
            get;
            set;
        }

        
    }
}
