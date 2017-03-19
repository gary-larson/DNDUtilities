using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Power_disiplines : DBTable
    {
        private int discipline_id
        {
            get;
            set;
        }

        public virtual string discipline
        {
            get;
            set;
        }

        public virtual Powers powers
        {
            get;
            set;
        }

    }


}
