using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monster_types : DBTable
    {
        private int type_id
        {
            get;
            set;
        }

        public virtual string type
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
