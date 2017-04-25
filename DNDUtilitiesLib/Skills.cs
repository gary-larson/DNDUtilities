using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skills : DBTable
    {
        public const string TABLE = "skills";
        public const string FIELD = "skill_id";
        public int skill_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public int key_ability_id
        {
            get;
            private set;
        }

        public string trained
        {
            get;
            set;
        }

        public string armor_checked
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public string spell_check
        {
            get;
            set;
        }

        public string action
        {
            get;
            set;
        }

        public string try_again
        {
            get;
            set;
        }

        public string special
        {
            get;
            set;
        }

        public string retriction
        {
            get;
            set;
        }

        public string synergy
        {
            get;
            set;
        }

        public string epic_use
        {
            get;
            set;
        }

        public string untrained
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

        public void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public Skills retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get all skills names
        /// </summary>
        /// <returns>list of all skills names</returns>
        public static List<NameKey> retrieveAllSkills()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
