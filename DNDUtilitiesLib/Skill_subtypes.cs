using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skill_subtypes : DBTable
    {
        private int subtype_id
        {
            get;
            set;
        }

        public virtual string subtype
        {
            get;
            set;
        }

        private int skill_id
        {
            get;
            set;
        }

    }
}
