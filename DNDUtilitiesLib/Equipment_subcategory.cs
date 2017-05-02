using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    class Equipment_subcategory : DBTable_lookup
    {

        public int subcategory_id
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
