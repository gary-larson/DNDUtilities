using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Combat_statistics : DBTable_lookup
    {
        public int combat_statistic_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
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
