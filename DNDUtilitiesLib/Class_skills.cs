using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_skills : DBTable
    {
        private int class_id
        {
            get;
            set;
        }

        private int skill_id
        {
            get;
            set;
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

    }


}
