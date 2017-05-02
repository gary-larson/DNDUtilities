using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monster_descriptor : DBTable_lookup
    {
        public int descriptor_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public Monsters monsters
        {
            get;
            set;
        }

        

    }

}
