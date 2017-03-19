using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Items : DBTable
    {
        private int item_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string category
        {
            get;
            set;
        }

        public virtual string subcategory
        {
            get;
            set;
        }

        public virtual string special_ability
        {
            get;
            set;
        }

        public virtual string aura
        {
            get;
            set;
        }

        public virtual int caster_level
        {
            get;
            set;
        }

        public virtual string price
        {
            get;
            set;
        }

        public virtual int manifester_level
        {
            get;
            set;
        }

        public virtual string prerequisite
        {
            get;
            set;
        }

        public virtual string cost
        {
            get;
            set;
        }

        public virtual string weight
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

    }


}
