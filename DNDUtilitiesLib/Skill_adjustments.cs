using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skill_adjustments : DBTable_bridge
    {
        public int skill_adjustment_id
        {
            get;
            private set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        public int adjustment
        {
            get;
            set;
        }

        public string condition
        {
            get;
            set;
        }

        public int race_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
        }

        

        
    }
}
