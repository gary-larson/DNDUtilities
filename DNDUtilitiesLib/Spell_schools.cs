using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spell_schools : DBTable_lookup
    {
        public int school_id
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
