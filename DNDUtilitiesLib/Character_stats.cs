using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_stats : DBTable
    {
        private int character_id
        {
            get;
            set;
        }

        public virtual int total
        {
            get;
            set;
        }

        public virtual int armor_bonus
        {
            get;
            set;
        }

        public virtual int shield_bonus
        {
            get;
            set;
        }

        public virtual int dex_modifier
        {
            get;
            set;
        }

        public virtual int size_modifier
        {
            get;
            set;
        }

        public virtual int natural_armor
        {
            get;
            set;
        }

        public virtual int deflection_modifier
        {
            get;
            set;
        }

        public virtual int misc_modifier
        {
            get;
            set;
        }

        public virtual int damage_reduction
        {
            get;
            set;
        }

        public virtual int touch
        {
            get;
            set;
        }

        public virtual int flat_footed
        {
            get;
            set;
        }

        public virtual int initiative_total
        {
            get;
            set;
        }

        public virtual int initiative_dex_modifier
	    {
		    get;
		    set;
	    }

        public virtual int initiative_misc_modifier
	    {
		    get;
		    set;
	    }

        public virtual int fortitude
        {
            get;
            set;
        }

        public virtual object fortitude_base_save
        {
            get;
            set;
        }

        public virtual int fortitude_ability_modifier
        {
            get;
            set;
        }

        public virtual int fortitude_magic_modifier
        {
            get;
            set;
        }

        public virtual int fortitude_misc_modifier
        {
            get;
            set;
        }

        public virtual int fortitude_temp_modifier
        {
            get;
            set;
        }

        public virtual string fortitude_conditions
        {
            get;
            set;
        }

        public virtual int reflex
        {
            get;
            set;
        }

        public virtual int reflex_base_save
        {
            get;
            set;
        }

        public virtual int reflex_ability_modifier
        {
            get;
            set;
        }

        public virtual int reflex_magic_modifier
        {
            get;
            set;
        }

        public virtual int reflex_misc_modifier
        {
            get;
            set;
        }

        public virtual int reflex_temp_modifier
        {
            get;
            set;
        }

        public virtual int reflex_conditions
        {
            get;
            set;
        }

        public virtual int will
        {
            get;
            set;
        }

        public virtual int will_base_save
        {
            get;
            set;
        }

        public virtual int will_ability_modifier
        {
            get;
            set;
        }

        public virtual int will_magic_modifier
        {
            get;
            set;
        }

        public virtual int will_misc_modifier
        {
            get;
            set;
        }

        public virtual int will_temp_modifier
        {
            get;
            set;
        }

        public virtual string will_conditions
        {
            get;
            set;
        }

        public virtual int base_attack_bonus
        {
            get;
            set;
        }

        public virtual int spell_resistance
        {
            get;
            set;
        }

        public virtual int grapple
        {
            get;
            set;
        }

        public virtual int grapple_base_attack_bonus
        {
            get;
            set;
        }

        public virtual int grapple_str_modifier
        {
            get;
            set;
        }

        public virtual int grapple_size_modifier
        {
            get;
            set;
        }

        public virtual int grapple_misc_modifier
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
