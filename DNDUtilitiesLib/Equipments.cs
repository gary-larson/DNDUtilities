using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Equipments : DBTable
    {
        private int equipment_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string family
        {
            get;
            set;
        }

        private int category_id
        {
            get;
            set;
        }

        private int subcategory_id
        {
            get;
            set;
        }

        public virtual string cost
        {
            get;
            set;
        }

        public virtual string dmg_s
        {
            get;
            set;
        }

        public virtual string weight
        {
            get;
            set;
        }

        public virtual string critical
        {
            get;
            set;
        }

        public virtual int armor_shield_bonus
        {
            get;
            set;
        }

        public virtual string dmg_m
        {
            get;
            set;
        }

        public virtual int maximum_dex_bonus
        {
            get;
            set;
        }

        public virtual int armor_check_penalty
        {
            get;
            set;
        }

        public virtual int arcane_spell_failure_chance
        {
            get;
            set;
        }

        public virtual int range_increment
        {
            get;
            set;
        }

        public virtual int speed_30
        {
            get;
            set;
        }

        public virtual string type
        {
            get;
            set;
        }

        public virtual int speed_20
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        public virtual Equipment_subcategory equipment_subcategory
        {
            get;
            set;
        }

        public virtual Equipment_category equipment_category
        {
            get;
            set;
        }

    }


}
