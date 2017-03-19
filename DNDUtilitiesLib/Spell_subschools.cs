using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spell_subschools : DBTable
    {
        private int subschool_id
        {
            get;
            set;
        }

        public virtual string subschool
        {
            get;
            set;
        }

    }
}
