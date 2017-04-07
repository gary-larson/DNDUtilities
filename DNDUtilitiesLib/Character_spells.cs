using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_spells : DBTable_bridge
    {
        private int character_id
        {
            get;
            set;
        }

        private int spell_id
        {
            get;
            set;
        }

        public virtual Spells Spells
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
