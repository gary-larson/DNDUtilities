using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Combat_statistics_adjustments : DBTable_bridge
    {
        public int combat_statistic_adjustment_id
        {
            get;
            private set;
        }

        public virtual int adjustment
        {
            get;
            set;
        }

        public virtual string condition
        {
            get;
            set;
        }

        public int race_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
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

        public virtual Races races
        {
            get;
            set;
        }

        public virtual IEnumerable<Classes> Classes
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
