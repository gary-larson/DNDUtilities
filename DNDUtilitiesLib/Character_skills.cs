using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_skills
    /// </summary>
    public class Character_skills : DBTable_bridge
    {
        // Declare constants
        const string TABLE = "character_skills";
        const string FIELD1 = "character_id";
        const string FIELD2 = "skill_id";

        // Setup fields with properties
        private int character_id
        {
            get;
            set;
        }

        private int skill_id
        {
            get;
            set;
        }

        public int skill_rank
        {
            get;
            set;
        }

        public int skill_modifier
        {
            get;
            set;
        }

        public int ability_modifier
        {
            get;
            set;
        }

        public int misc_modifier
        {
            get;
            set;
        }
    }
}
