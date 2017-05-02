using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    class Monster_families : DBTable_lookup
    {

        public int family_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        
    }
}
