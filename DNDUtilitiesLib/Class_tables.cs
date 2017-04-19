using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_tables : DBTable
    {
        public int class_table_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
        }

        public virtual int level
        {
            get;
            set;
        }

        public virtual string base_attack_bonus
        {
            get;
            set;
        }

        public virtual int fort_save
        {
            get;
            set;
        }

        public virtual int ref_save
        {
            get;
            set;
        }

        public virtual int will_save
        {
            get;
            set;
        }

        public virtual int ac_bonus
        {
            get;
            set;
        }

        public virtual int flurry_of_blows
        {
            get;
            set;
        }

        public virtual int unarmored_speed_bonus
        {
            get;
            set;
        }

        public virtual string unarmed_damage
        {
            get;
            set;
        }

        public virtual string special
        {
            get;
            set;
        }

        public virtual int slots_0
        {
            get;
            set;
        }

        public virtual int slots_1
        {
            get;
            set;
        }

        public virtual int slots_2
        {
            get;
            set;
        }

        public virtual int slots_3
        {
            get;
            set;
        }

        public virtual int slots_4
        {
            get;
            set;
        }

        public virtual int slots_5
        {
            get;
            set;
        }

        public virtual int slots_6
        {
            get;
            set;
        }

        public virtual int slots_7
        {
            get;
            set;
        }

        public virtual int slots_8
        {
            get;
            set;
        }

        public virtual int slots_9
        {
            get;
            set;
        }

        public virtual int spells_known_0
        {
            get;
            set;
        }

        public virtual int spells_known_1
        {
            get;
            set;
        }

        public virtual int spells_known_2
        {
            get;
            set;
        }

        public virtual int spells_known_4
        {
            get;
            set;
        }

        public virtual int spells_known_5
        {
            get;
            set;
        }

        public virtual int spells_known_6
        {
            get;
            set;
        }

        public virtual int spells_known_7
        {
            get;
            set;
        }

        public virtual int spells_known_8
        {
            get;
            set;
        }

        public virtual int spells_known_9
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual Classes classes
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Class_tables retrieve(int Key)
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
