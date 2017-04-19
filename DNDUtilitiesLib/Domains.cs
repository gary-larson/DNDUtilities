using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Domains : DBTable
    {
        public int domain_id
        {
            get;
            private set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string granted_powers
        {
            get;
            set;
        }

        public virtual string spell_1
        {
            get;
            set;
        }

        public virtual string spell_2
        {
            get;
            set;
        }

        public virtual string spell_3
        {
            get;
            set;
        }

        public virtual string spell_4
        {
            get;
            set;
        }

        public virtual string spell_5
        {
            get;
            set;
        }

        public virtual string spell_6
        {
            get;
            set;
        }

        public virtual string spell_7
        {
            get;
            set;
        }

        public virtual string spell_8
        {
            get;
            set;
        }

        public virtual string spell_9
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

        public virtual Domains retrieve(int Key)
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
