using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Powers : DBTable
    {
        private int power_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        private int power_discipline_id
        {
            get;
            set;
        }

        private int power_subdiscipline_id
        {
            get;
            set;
        }

        public virtual string descriptor
        {
            get;
            set;
        }

        public virtual string level
        {
            get;
            set;
        }

        public virtual string display
        {
            get;
            set;
        }

        public virtual string maifesting-time
	{
		get;
		set;
	}

    public virtual string range
    {
        get;
        set;
    }

    public virtual string target
    {
        get;
        set;
    }

    public virtual string area
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

    public virtual string saving-throw
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

public virtual string short-description
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

}
}
