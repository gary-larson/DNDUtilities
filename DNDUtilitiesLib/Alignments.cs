using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table alignments
    /// </summary>
    public class Alignments : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "alignments";
        const string FIELD = "alignment_id";

        // Setup fields with properties
        public int alignment_id
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
        /// Gets all records
        /// </summary>
        /// <returns>list of name and ability_id</returns>
        public static List<NameKey> retrieveAllAlignments()
        {
            return retrieveAll(TABLE, FIELD);
        }

        /// <summary>
        /// Gets record based on ability_id
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>the record requested</returns>
        public Alignments retrieveRecord(int Key)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "select alignment_id, name from alignments where alignment_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", Key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        alignment_id = read.GetInt32(0);
                        name = read.GetString(1);
                    }
                    return this;
                }
            }
        }
        /// <summary>
        /// represents this object as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Alignment " + name + " alignment_id: " + alignment_id;
        }

    }

}
