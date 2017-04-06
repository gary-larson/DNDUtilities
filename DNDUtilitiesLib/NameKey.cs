using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class NameKey
    {
        private int key
        {
            get;
            set;
        }

        private string name
        {
            get;
            set;
        }

        public NameKey (int key, string name)
        {
            this.key = key;
            this.name = name;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
