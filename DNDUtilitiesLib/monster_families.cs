using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    class Monster_families : DBTable_lookup
    {

        public int family_id
        {
            get;
            private set;
        }

        public virtual string name
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual Monsters monsters
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Monster_families retrieve(int Key)
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
