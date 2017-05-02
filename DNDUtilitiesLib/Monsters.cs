using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monsters : DBTable
    {
        public int monster_id
        {
            get;
            private set;
        }

        public int monster_family_id
	    {
		    get;
		    private set;
	    }

        public string name
        {
            get;
            set;
        }

        public string altname
        {
            get;
            set;
        }

        public int size_id
        {
            get;
            private set;
        }

        public int type_id
        {
            get;
            private set;
        }

        public int descriptor_id
        {
            get;
            private set;
        }

        public string hit_dice
        {
            get;
            set;
        }

        public string initiative
        {
            get;
            set;
        }

        public string speed
        {
            get;
            set;
        }

        public string armor_class
        {
            get;
            set;
        }

        public int base_attack
        {
            get;
            set;
        }

        public int grapple
        {
            get;
            set;
        }

        public string attack
        {
            get;
            set;
        }

        public string full_attack
        {
            get;
            set;
        }

        public string space
        {
            get;
            set;
        }

        public string reach
        {
            get;
            set;
        }

        public string special_attacks
	    {
		    get;
		    set;
	    }

        public string special_qualities
	    {
		    get;
		    set;
	    }

	    public string saves
        {
            get;
            set;
        }

        public string abilities
        {
            get;
            set;
        }

        public string skills
        {
            get;
            set;
        }

        public string bonus_feats
        {
            get;
            set;
        }

        public string feats
        {
            get;
            set;
        }

        public string epic_feats
        {
            get;
            set;
        }

        public string environment
        {
            get;
            set;
        }

        public string organization
        {
            get;
            set;
        }

        public string challenge_rating
        {
            get;
            set;
        }

        public string treasure
        {
            get;
            set;
        }

        public string alignment
        {
            get;
            set;
        }

        public string advancement
        {
            get;
            set;
        }

        public string level_adjustment
        {
            get;
            set;
        }

        public string special_abilities
	        {
		        get;
		        set;
	        }

	        public string stat_block
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
