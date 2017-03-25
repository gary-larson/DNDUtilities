using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Ability_check_adjustments : DBTable_bridge
    {
        private int ability_check_id
        {
            get;
            set;
        }

        private int ability_id
        {
            get;
            set;
        }

        private int race_id
        {
            get;
            set;
        }

        private int class_id
        {
            get;
            set;
        }

        public virtual string adjustment
        {
            get;
            set;
        }

        public virtual string condition
        {
            get;
            set;
        }

        internal virtual string FIELD
        {
            get;
            set;
        }

        internal virtual string FIELD_LIST
        {
            get;
            set;
        }

        internal virtual string TABLE
        {
            get;
            set;
        }

        public virtual Abilities Abilities
        {
            get;
            set;
        }

        public virtual Classes Classes
        {
            get;
            set;
        }

        public virtual IEnumerable<Races> races
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Domains retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
