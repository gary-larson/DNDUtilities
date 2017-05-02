using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Racial_favored_classes : DBTable_bridge
    {
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

        
    }
}
