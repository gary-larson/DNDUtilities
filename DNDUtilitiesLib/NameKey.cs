using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class NameKey
    {
        public int key
        {
            // class altered to make key accessibel for reading, not accessible for writing. this prevents corruption, 
            // security is not our perogative
            get;
            private set;
        }

        public string name
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
