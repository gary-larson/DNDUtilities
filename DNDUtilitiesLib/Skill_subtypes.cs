using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skill_subtypes : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "skill_subtypes";
        const string FIELD = "subtype_id";
        public int subtype_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        // Declare constructors
        public Skill_subtypes()
        {
            subtype_id = -1;
            name = "";
            skill_id = -1;
        }

        public Skill_subtypes(int subtypeKey, string subtype, int skillKey)
        {
            subtype_id = subtypeKey;
            name = subtype;
            skill_id = skillKey;
        }

        /// <summary>
        /// gets all records 
        /// </summary>
        /// <param name="key">the skill key to locate</param>
        /// <returns>returns a List with name and subtype_id</returns>
        public static List<NameKey> retrieveAllSubTypes(int skillKey)
        {
            return retrieveAll(TABLE, FIELD, skillKey);
        }

        /// <summary>
        /// outputs object as a string
        /// </summary>
        /// <returns>String representing object</returns>
        public override string ToString()
        {
            return "SubType_id: " + subtype_id + " Name: " + name + " skill_id: " + skill_id;
        }
    }
}
