using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spells : DBTable
    {
        private int spell_id
        {
            get;
            set;
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

        private int school_id
        {
            get;
            set;
        }

        private int subschool_id
        {
            get;
            set;
        }

        public virtual string descriptor
        {
            get;
            set;
        }

        public virtual string spellcraft_dc
        {
            get;
            set;
        }

        public virtual string level
        {
            get;
            set;
        }

        public virtual string components
        {
            get;
            set;
        }

        public virtual string casting_time
        {
            get;
            set;
        }

        public virtual string range
        {
            get;
            set;
        }

        public virtual string target
        {
            get;
            set;
        }

        public virtual string area
        {
            get;
            set;
        }

        public virtual string effect
        {
            get;
            set;
        }

        public virtual string duration
        {
            get;
            set;
        }

        public virtual string saving_throw
        {
            get;
            set;
        }

        public virtual string spell_resistance
        {
            get;
            set;
        }

        public virtual string short_description
        {
            get;
            set;
        }

        public virtual string to_develop
        {
            get;
            set;
        }

        public virtual object material_components
        {
            get;
            set;
        }

        public virtual string arcane_material_components
        {
            get;
            set;
        }

        public virtual string focus
        {
            get;
            set;
        }

        public virtual string description
        {
            get;
            set;
        }

        public virtual string xp_cost
        {
            get;
            set;
        }

        public virtual string arcane_focus
        {
            get;
            set;
        }

        public virtual string wizard_focus
        {
            get;
            set;
        }

        public virtual string verbal_components
        {
            get;
            set;
        }

        public virtual string sorcerer_focus
        {
            get;
            set;
        }

        public virtual string bard_focus
        {
            get;
            set;
        }

        public virtual string druid_focus
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        public virtual Spell_schools spell_schools
        {
            get;
            set;
        }

        public virtual Spell_subschools spell_subschools
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

        public virtual Spells retrieve(int Key)
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
