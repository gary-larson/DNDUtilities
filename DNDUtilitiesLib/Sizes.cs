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

        public void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public Sizes retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get all sizes names
        /// </summary>
        /// <returns>list of all sizes names</returns>
        public static List<NameKey> retrieveAllSizes()
        {
            return retrieveAll(TABLE, FIELD);
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
