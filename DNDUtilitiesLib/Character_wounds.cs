using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_wounds : DBTable_lookup
    {
        private int character_id
        {
            get;
            set;
        }

        private int wound_id
        {
            get;
            set;
        }

        public virtual int amount
        {
            get;
            set;
        }

        public virtual bool lethal
        {
            get;
            set;
        }

        public virtual bool deleted
        {
            get;
            set;
        }

        public virtual Characters Characters
        {
            get;
            set;
        }
    }
}
