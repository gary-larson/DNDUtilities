using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Powers : DBTable
    {
        public int power_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public int power_discipline_id
        {
            get;
            private set;
        }

        public int power_subdiscipline_id
        {
            get;
            private set;
        }

        public string descriptor
        {
            get;
            set;
        }

        public string level
        {
            get;
            set;
        }

        public string display
        {
            get;
            set;
        }

        public string maifesting_time
	    {
		    get;
		    set;
	    }

        public string range
        {
            get;
            set;
        }

        public string target
        {
            get;
            set;
        }

        public string area
        {
            get;
            set;
        }

        public virtual string effect
        {
            get;
            set;
        }

        public virtual string duration
        {
            get;
            set;
        }

        public virtual string saving_throw
	    {
		    get;
		    set;
	    }

        public virtual string power_points
        {
            get;
            set;
        }

        public virtual string power_resistance
        {
            get;
            set;
        }

        public virtual string short_description
	    {
		    get;
		    set;
	    }

	    public virtual string xp_cost
        {
            get;
            set;
        }

        public virtual string description
        {
            get;
            set;
        }

        public virtual string augment
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        

        public override string ToString()
        {
            return name;
        }

    }
}
