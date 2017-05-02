using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Items : DBTable
    {
        public int item_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public string category
        {
            get;
            set;
        }

        public string subcategory
        {
            get;
            set;
        }

        public string special_ability
        {
            get;
            set;
        }

        public string aura
        {
            get;
            set;
        }

        public int caster_level
        {
            get;
            set;
        }

        public string price
        {
            get;
            set;
        }

        public int manifester_level
        {
            get;
            set;
        }

        public string prerequisite
        {
            get;
            set;
        }

        public string cost
        {
            get;
            set;
        }

        public string weight
        {
            get;
            set;
        }

        public string full_text
        {
            get;
            set;
        }

        

    }


}
