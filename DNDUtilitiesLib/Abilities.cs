using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Abilities : DBTable
    {
        private int ability_id
        {
            get;
            set;
        }

        public virtual string ability
        {
            get;
            set;
        }

        public virtual string abbreviation
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
