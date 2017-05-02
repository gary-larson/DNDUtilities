using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Sizes : DBTable_lookup
    {
        public const string TABLE = "sizes";
        public const string FIELD = "size_id";
        public int size_id
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
        /// Get all sizes names
        /// </summary>
        /// <returns>list of all sizes names</returns>
        public static List<NameKey> retrieveAllSizes()
        {
            return retrieveAll(TABLE, FIELD);
        }

        
    }
}
