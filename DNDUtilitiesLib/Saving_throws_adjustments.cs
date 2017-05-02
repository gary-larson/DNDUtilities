using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Saving_throw_adjustments : DBTable_bridge
    {
        public int saving_throw_adjustment_id
        {
            get;
            private set;
        }

        public int saving_throw_id
        {
            get;
            private set;
        }

        public int adjustment
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
