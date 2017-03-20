﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Classes : DBTable
    {
        private int class_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string type
        {
            get;
            set;
        }

        public virtual int hit_die
        {
            get;
            set;
        }

        public virtual int skill_points
        {
            get;
            set;
        }

        private int ability_id
        {
            get;
            set;
        }

        private int type_id
        {
            get;
            set;
        }

        public virtual string proficiencies
        {
            get;
            set;
        }

        public virtual int epic_feat_base_level
        {
            get;
            set;
        }

        public virtual int epic_feat_interval
        {
            get;
            set;
        }

        public virtual string epic_feat_list
        {
            get;
            set;
        }

        public virtual string epic_full_text
        {
            get;
            set;
        }

        public virtual string req_race
        {
            get;
            set;
        }

        public virtual string req_weapon_proficiency
        {
            get;
            set;
        }

        public virtual int req_base_attack_bonus
        {
            get;
            set;
        }

        public virtual string req_skill
        {
            get;
            set;
        }

        public virtual string req_feat
        {
            get;
            set;
        }

        public virtual string req_spells
        {
            get;
            set;
        }

        public virtual string req_languages
        {
            get;
            set;
        }

        public virtual string req_psionics
	    {
		    get;
		    set;
	    }

        public virtual string req_epic_feat
        {
            get;
            set;
        }

        public virtual string req_special
        {
            get;
            set;
        }

        public virtual string spell_list_1
        {
            get;
            set;
        }

        public virtual string spell_list_2
        {
            get;
            set;
        }

        public virtual string spell_list_3
        {
            get;
            set;
        }

        public virtual string spell_list_4
        {
            get;
            set;
        }

        public virtual string spell_list_5
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
