using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_skills : DBTable_bridge
    {

        const string TABLE = "class_skills";
        const string LIST_TABLE = "skills";
        const string FIELD1 = "class_id";
        const string FIELD2 = "skill_id";
        public int class_id
        {
            get;
            private set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Class_skills()
        {
            class_id = -1;
            skill_id = -1;
        }

        /// <summary>
        /// Constructor to assign values to fields
        /// </summary>
        /// <param name="characterKey">Character key</param>
        /// <param name="featKey">Feat key</param>
        public Class_skills(int classKey, int skillKey)
        {
            class_id = classKey;
            skill_id = skillKey;
        }

        /// <summary>
        /// Gets all skills for the class
        /// </summary>
        /// <param name="key">the class key</param>
        /// <returns>List of name and keys for the skills</returns>
        public static List<NameKey> retrieveAllSkills(int key)
        {
            return retrieveAll(TABLE, LIST_TABLE, FIELD2, FIELD1, key);
        }

    }


}
