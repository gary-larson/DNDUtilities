using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table class_alignments
    /// </summary>
    public class Class_alignments : DBTable_bridge
    {
        // Declare constants
        const string TABLE = "class_alignments";
        const string LIST_TABLE = "alignments";
        const string SELECT_FIELD = "class_id";
        const string LIST_FIELD = "alignment_id";

        // Setup fields with properties
        public int class_id
        {
            get;
            private set;
        }

        public int alignment_id
	    {
		    get;
		    private set;
	    }

        /// <summary>
        /// Gets all the alignments associated with a class
        /// </summary>
        /// <param name="classKey">Class to retrieve alignments for</param>
        /// <returns>List of name and keys</returns>
        public static List<NameKey> retrieveAllAlignments(int classKey)
        {
            return retrieveAll(TABLE, LIST_TABLE, LIST_FIELD, SELECT_FIELD, classKey);
        }

        /// <summary>
        /// Represents object as a string
        /// </summary>
        /// <returns>string representation of object</returns>
        public override string ToString()
        {
            return "class_id: " + class_id + "allignment_id: " + alignment_id;
        }

    }


}
