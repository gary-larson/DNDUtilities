using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_wounds
    /// </summary>
    public class Character_wounds : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "character_wounds";
        const string FIELD = " character_id";

        // Setup fields with properties
        private int character_id
        {
            get;
            set;
        }

        private int wound_id
        {
            get;
            set;
        }

        public int amount
        {
            get;
            set;
        }

        public bool lethal
        {
            get;
            set;
        }

        public bool deleted
        {
            get;
            set;
        }
    }
}
