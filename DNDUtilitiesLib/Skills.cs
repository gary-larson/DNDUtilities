using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skills : DBTable
    {
        private int skill_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        private int key_ability_id
        {
            get;
            set;
        }

        public virtual string trained
        {
            get;
            set;
        }

        public virtual string armor_checked
        {
            get;
            set;
        }

        public virtual string description
        {
            get;
            set;
        }

        public virtual string spell_check
        {
            get;
            set;
        }

        public virtual string action
        {
            get;
            set;
        }

        public virtual string try_again
        {
            get;
            set;
        }

        public virtual string special
        {
            get;
            set;
        }

        public virtual string retriction
        {
            get;
            set;
        }

        public virtual string synergy
        {
            get;
            set;
        }

        public virtual string epic_use
        {
            get;
            set;
        }

        public virtual string untrained
        {
            get;
            set;
        }

        public virtual string psionic
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        public virtual IEnumerable<Skill_subtypes> skill_subtypes
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Skills retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
