using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Power_subdisciplines : DBTable_lookup
    {
        public int subdiscipline_id
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
