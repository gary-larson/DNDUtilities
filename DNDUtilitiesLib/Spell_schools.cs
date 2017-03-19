using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spell_schools : DBTable
    {
        private int school_id
        {
            get;
            set;
        }

        public virtual string school
        {
            get;
            set;
        }

    }
}
