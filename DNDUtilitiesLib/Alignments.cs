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

        public virtual string alignment
        {
            get;
            set;
        }

    }

}
