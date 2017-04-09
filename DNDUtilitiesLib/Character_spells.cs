using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{

    /// <summary>
    /// Class that represents a record of the database table character_spells
    /// </summary>
    public class Character_spells : DBTable_bridge
    {

        // Declare constants
        const string TABLE = "character_spells";
        const string FIELD1 = "character_id";
        const string FIELD2 = "spell_id";

        // Setup fields with properties
        private int character_id
        {
            get;
            set;
        }

        private int spell_id
        {
            get;
            set;
        }
    }
}
