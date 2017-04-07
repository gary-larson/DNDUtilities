using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_skills : DBTable_bridge
    {
        private int character_id
        {
            get;
            set;
        }

        private int skill_id
        {
            get;
            set;
        }

        public virtual int skill_rank
        {
            get;
            set;
        }

        public virtual int skill_modifier
        {
            get;
            set;
        }

        public virtual int ability_modifier
        {
            get;
            set;
        }

        public virtual int misc_modifier
        {
            get;
            set;
        }

        public virtual Skills Skills
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
