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

        public virtual string name
        {
            get;
            set;
        }

        public virtual string altname
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

        public virtual string hit_dice
        {
            get;
            set;
        }

        public virtual string initiative
        {
            get;
            set;
        }

        public virtual string speed
        {
            get;
            set;
        }

        public virtual string armor_class
        {
            get;
            set;
        }

        public virtual int base_attack
        {
            get;
            set;
        }

        public virtual int grapple
        {
            get;
            set;
        }

        public virtual string attack
        {
            get;
            set;
        }

        public virtual string full_attack
        {
            get;
            set;
        }

        public virtual string space
        {
            get;
            set;
        }

        public virtual string reach
        {
            get;
            set;
        }

        public virtual string special_attacks
	    {
		    get;
		    set;
	    }

        public virtual string special_qualities
	    {
		    get;
		    set;
	    }

	    public virtual string saves
        {
            get;
            set;
        }

        public virtual string abilities
        {
            get;
            set;
        }

        public virtual string skills
        {
            get;
            set;
        }

        public virtual string bonus_feats
        {
            get;
            set;
        }

        public virtual string feats
        {
            get;
            set;
        }

        public virtual string epic_feats
        {
            get;
            set;
        }

        public virtual string environment
        {
            get;
            set;
        }

        public virtual string organization
        {
            get;
            set;
        }

        public virtual string challenge_rating
        {
            get;
            set;
        }

        public virtual string treasure
        {
            get;
            set;
        }

        public virtual string alignment
        {
            get;
            set;
        }

        public virtual string advancement
        {
            get;
            set;
        }

        public virtual string level_adjustment
        {
            get;
            set;
        }

        public virtual string special_abilities
	        {
		        get;
		        set;
	        }

	        public virtual string stat_block
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Monsters retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
