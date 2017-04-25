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

        

        public void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public Domains retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get all language names
        /// </summary>
        /// <returns>list of all languages names</returns>
        public static List<NameKey> retrieveAllLanguages()
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
