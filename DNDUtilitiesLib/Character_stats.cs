using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_stats
    /// </summary>
    public class Character_stats : DBTable
    {
        //Declare constants
        const string TABLE = "character_stats";
        const string FIELD = "character_id";

        // Setup fields with properties
        private int character_id
        {
            get;
            set;
        }

        public int total
        {
            get;
            set;
        }

        public int armor_bonus
        {
            get;
            set;
        }

        public int shield_bonus
        {
            get;
            set;
        }

        public int dex_modifier
        {
            get;
            set;
        }

        public int size_modifier
        {
            get;
            set;
        }

        public int natural_armor
        {
            get;
            set;
        }

        public int deflection_modifier
        {
            get;
            set;
        }

        public int misc_modifier
        {
            get;
            set;
        }

        public int damage_reduction
        {
            get;
            set;
        }

        public int touch
        {
            get;
            set;
        }

        public int flat_footed
        {
            get;
            set;
        }

        public int initiative_total
        {
            get;
            set;
        }

        public int initiative_dex_modifier
	    {
		    get;
		    set;
	    }

        public int initiative_misc_modifier
	    {
		    get;
		    set;
	    }

        public int fortitude
        {
            get;
            set;
        }

        public object fortitude_base_save
        {
            get;
            set;
        }

        public int fortitude_ability_modifier
        {
            get;
            set;
        }

        public int fortitude_magic_modifier
        {
            get;
            set;
        }

        public int fortitude_misc_modifier
        {
            get;
            set;
        }

        public int fortitude_temp_modifier
        {
            get;
            set;
        }

        public string fortitude_conditions
        {
            get;
            set;
        }

        public int reflex
        {
            get;
            set;
        }

        public int reflex_base_save
        {
            get;
            set;
        }

        public int reflex_ability_modifier
        {
            get;
            set;
        }

        public int reflex_magic_modifier
        {
            get;
            set;
        }

        public int reflex_misc_modifier
        {
            get;
            set;
        }

        public int reflex_temp_modifier
        {
            get;
            set;
        }

        public int reflex_conditions
        {
            get;
            set;
        }

        public int will
        {
            get;
            set;
        }

        public int will_base_save
        {
            get;
            set;
        }

        public int will_ability_modifier
        {
            get;
            set;
        }

        public int will_magic_modifier
        {
            get;
            set;
        }

        public int will_misc_modifier
        {
            get;
            set;
        }

        public int will_temp_modifier
        {
            get;
            set;
        }

        public string will_conditions
        {
            get;
            set;
        }

        public int base_attack_bonus
        {
            get;
            set;
        }

        public int spell_resistance
        {
            get;
            set;
        }

        public int grapple
        {
            get;
            set;
        }

        public int grapple_base_attack_bonus
        {
            get;
            set;
        }

        public int grapple_str_modifier
        {
            get;
            set;
        }

        public int grapple_size_modifier
        {
            get;
            set;
        }

        public int grapple_misc_modifier
        {
            get;
            set;
        }
    }
}
