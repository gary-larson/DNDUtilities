using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Combat_statistics_adjustments : DBTable_bridge
    {
        public int combat_statistic_adjustment_id
        {
            get;
            private set;
        }

        public int adjustment
        {
            get;
            set;
        }

        public string condition
        {
            get;
            set;
        }

        public int race_id
        {
            get;
            private set;
        }

        public int class_id
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
