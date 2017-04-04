using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_alignments : DBTable_bridge
    {
        private int alignment_class_id
        {
            get;
            set;
        }

        private int alignment_id
	    {
		    get;
		    set;
	    }

        public virtual Alignments Alignments
        {
            get;
            set;
        }

        public virtual Classes classes
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

        public virtual Class_alignments retrieve(int Key)
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
