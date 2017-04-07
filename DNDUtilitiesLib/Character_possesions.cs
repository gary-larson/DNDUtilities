using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_possesions : DBTable_bridge
    {
        private int character_id
        {
            get;
            set;
        }

        private int equipment_id
        {
            get;
            set;
        }

        public virtual int quantity
        {
            get;
            set;
        }

        public virtual string location
        {
            get;
            set;
        }

        public virtual int magic_value
        {
            get;
            set;
        }

        public virtual string special_properties
        {
            get;
            set;
        }

        public virtual Equipments Equipments
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
