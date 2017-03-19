using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Power_subdisciplines : DBTable
    {
        private int subdiscipline_id
        {
            get;
            set;
        }

        public virtual string subdiscipline
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
