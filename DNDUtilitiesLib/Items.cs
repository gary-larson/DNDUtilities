using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Items : DBTable
    {
        public int item_id
        {
            get;
            private set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string category
        {
            get;
            set;
        }

        public virtual string subcategory
        {
            get;
            set;
        }

        public virtual string special_ability
        {
            get;
            set;
        }

        public virtual string aura
        {
            get;
            set;
        }

        public virtual int caster_level
        {
            get;
            set;
        }

        public virtual string price
        {
            get;
            set;
        }

        public virtual int manifester_level
        {
            get;
            set;
        }

        public virtual string prerequisite
        {
            get;
            set;
        }

        public virtual string cost
        {
            get;
            set;
        }

        public virtual string weight
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

        public virtual Items retrieve(int Key)
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
