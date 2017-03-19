using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monster_families : DBTable
    {
        private int family_id
        {
            get;
            set;
        }

        public virtual string family
        {
            get;
            set;
        }

        public virtual Monsters monsters
        {
            get;
            set;
        }

    }
}
