using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Feats : DBTable
    {
        public const string TABLE = "feats";
        public const string FIELD = "feat_id";
        public int feat_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public string multiple
        {
            get;
            set;
        }

        public string stack
        {
            get;
            set;
        }

        public string choice
        {
            get;
            set;
        }

        public string prerequisite
        {
            get;
            set;
        }

        public string benefit
        {
            get;
            set;
        }

        public string normal
        {
            get;
            set;
        }

        public string special
        {
            get;
            set;
        }

        public string full_text
        {
            get;
            set;
        }

        
        /// <summary>
        /// Get all Feat names
        /// </summary>
        /// <returns>list of all feats</returns>
        public static List<NameKey> retrieveAllFeats()
        {
            return retrieveAll(TABLE, FIELD);
        }

        

    }


}
