using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monster_descriptor : DBTable_lookup
    {
        public int descriptor_id
        {
            get;
            private set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual Monsters monsters
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

        public virtual Monster_descriptor retrieve(int Key)
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
