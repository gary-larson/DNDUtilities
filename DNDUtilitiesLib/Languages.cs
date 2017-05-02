using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Languages : DBTable_lookup
    {
        public const string TABLE = "languages";
        public const string FIELD = "language_id";

        public int language_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        

        
        /// <summary>
        /// Get all language names
        /// </summary>
        /// <returns>list of all languages names</returns>
        public static List<NameKey> retrieveAllLanguages()
        {
            return retrieveAll(TABLE, FIELD);
        }

        
    }
}
