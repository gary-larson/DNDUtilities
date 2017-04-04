using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Alignments : DBTable
    {
        private int alignment_id
        {
            get;
            set;
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

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Alignments retrieve(int Key)
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
