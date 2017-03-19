using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monster_descriptor : DBTable
    {
        private int descriptor_id
        {
            get;
            set;
        }

        public virtual string descriptor
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
