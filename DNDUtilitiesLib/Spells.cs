using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spells : DBTable
    {
        public const string TABLE = "spells";
        public const string FIELD = "spell_id";
        public int spell_id
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

        public int school_id
        {
            get;
            private set;
        }

        public int subschool_id
        {
            get;
            private set;
        }

        public string descriptor
        {
            get;
            set;
        }

        public string spellcraft_dc
        {
            get;
            set;
        }

        public string level
        {
            get;
            set;
        }

        public string components
        {
            get;
            set;
        }

        public string casting_time
        {
            get;
            set;
        }

        public string range
        {
            get;
            set;
        }

        public string target
        {
            get;
            set;
        }

        public string area
        {
            get;
            set;
        }

        public string effect
        {
            get;
            set;
        }

        public string duration
        {
            get;
            set;
        }

        public string saving_throw
        {
            get;
            set;
        }

        public string spell_resistance
        {
            get;
            set;
        }

        public string short_description
        {
            get;
            set;
        }

        public string to_develop
        {
            get;
            set;
        }

        public string material_components
        {
            get;
            set;
        }

        public string arcane_material_components
        {
            get;
            set;
        }

        public string focus
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public string xp_cost
        {
            get;
            set;
        }

        public string arcane_focus
        {
            get;
            set;
        }

        public string wizard_focus
        {
            get;
            set;
        }

        public string verbal_components
        {
            get;
            set;
        }

        public string sorcerer_focus
        {
            get;
            set;
        }

        public string bard_focus
        {
            get;
            set;
        }

        public string druid_focus
        {
            get;
            set;
        }

        public string full_text
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public Spells retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get all spells names
        /// </summary>
        /// <returns>list of all spells names</returns>
        public static List<NameKey> retrieveAllSpells()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
