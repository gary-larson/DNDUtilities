using DNDUtilitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Equipments : DBTable
    {
        public const string TABLE = "equipments";
        public const string FIELD = "equipment_id";
        public int equipment_id
        {
            get;
            private set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public string family
        {
            get;
            set;
        }

        public int category_id
        {
            get;
            private set;
        }

        public int subcategory_id
        {
            get;
            private set;
        }

        public string cost
        {
            get;
            set;
        }

        public string dmg_s
        {
            get;
            set;
        }

        public string weight
        {
            get;
            set;
        }

        public string critical
        {
            get;
            set;
        }

        public int armor_shield_bonus
        {
            get;
            set;
        }

        public string dmg_m
        {
            get;
            set;
        }

        public int maximum_dex_bonus
        {
            get;
            set;
        }

        public int armor_check_penalty
        {
            get;
            set;
        }

        public int arcane_spell_failure_chance
        {
            get;
            set;
        }

        public int range_increment
        {
            get;
            set;
        }

        public int speed_30
        {
            get;
            set;
        }

        public virtual string type
        {
            get;
            set;
        }

        public int speed_20
        {
            get;
            set;
        }

        public string full_text
        {
            get;
            set;
        }

        /// <summary>
        /// Get all equipment names
        /// </summary>
        /// <returns>list of all equipment names</returns>
        public static List<NameKey> retrieveAllEquipment()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public Equipments retrieve(int Key)
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
