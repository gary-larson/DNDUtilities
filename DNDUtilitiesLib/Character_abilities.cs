using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_abilities : DBTable_bridge
    {
        private int character_id
        {
            get;
            set;
        }

        private int ability_id
        {
            get;
            set;
        }

        public virtual int modifier
        {
            get;
            set;
        }

        public virtual int temp
        {
            get;
            set;
        }

        public virtual int temp_modifier
        {
            get;
            set;
        }

        public virtual Abilities Abilities
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
