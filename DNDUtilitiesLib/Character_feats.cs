using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_feats : DBTable_bridge
    {
        private int character_id
        {
            get;
            set;
        }

        private int feat_id
        {
            get;
            set;
        }

        public virtual Feats Feats
        {
            get;
            set;
        }

        public virtual Characters Characters
        {
            get;
            set;
        }
    }
}
