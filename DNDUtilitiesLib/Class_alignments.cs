using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_alignments : DBTable
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

    }


}
