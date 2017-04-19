using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_skills : DBTable_bridge
    {
        public int class_id
        {
            get;
            private set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        public virtual Classes classes
        {
            get;
            set;
        }

        public virtual Skills skills
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

        public virtual Class_skills retrieve(int Key)
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
