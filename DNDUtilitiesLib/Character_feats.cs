using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_feats
    /// </summary>
    public class Character_feats : DBTable_bridge
    {
        // Declare constants
        const string TABLE = "character_feats";
        const string LIST_TABLE = "feats";
        const string FIELD1 = "character_id";
        const string FIELD2 = "feat_id";

        //Setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public int feat_id
        {
            get;
            private set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Character_feats ()
        {
            character_id = -1;
            feat_id = -1;
        }

        /// <summary>
        /// Constructor to assign values to fields
        /// </summary>
        /// <param name="characterKey">Character key</param>
        /// <param name="featKey">Feat key</param>
        public Character_feats(int characterKey, int featKey)
        {
            character_id = characterKey;
            feat_id = featKey;
        }

        /// <summary>
        /// Removes a record from table
        /// </summary>
        /// <param name="character_id">part of primary key</param>
        /// <param name="feat_id">part of primary key</param>
        /// <returns>True if record is deleted False otherwise</returns>
        public static bool delete(int character_id, int feat_id)
        {
            string sql;

            if (keyExists(TABLE, FIELD1, FIELD2, character_id, feat_id))
            {
                sql = "DELETE FROM character_feats WHERE character_id = @id1 AND feat_id = @id2";
                int i = runSqlite(sql, character_id, feat_id);
                if (i > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        } 

        /// <summary>
        /// Gets all feats for the character
        /// </summary>
        /// <param name="key">the character key</param>
        /// <returns>List of name and keys for the feats</returns>
        public static List<NameKey> retrieveAllFeats (int key)
        {
            return retrieveAll(TABLE, LIST_TABLE, FIELD2, FIELD1, key);
        }

        /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        /// <param name="characterKey">character key if included it is used else uses character_id</param>
        /// <param name=featKey">feat key if included it is used else uses feat_id</param>
        public bool save(int characterKey = -1, int featKey = -1)
        {
            String sql;

            if (characterKey > 0)
            {
                character_id = characterKey;
            }
            if (featKey > 0)
            {
                feat_id = featKey;
            }
            if (!keyExists(TABLE, FIELD1, FIELD2, character_id, feat_id))
            {
                sql = "INSERT INTO character_feats (character_id, feat_id)" +
                    " VALUES (@id1, @id2)";
                int i = runSqlite(sql, character_id, feat_id);
                if (i > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Helper method to process Sql command
        /// </summary>
        /// <param name="sql">Sql command to process</param>
        /// <returns>number of records affected</returns>
        private static int runSqlite(String sql, int character_id, int feat_id)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", character_id);
                command.Parameters.AddWithValue("id2", feat_id);
                

                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        public override string ToString()
        {
            return "Feat_id: " + feat_id + " character_id: " + character_id;
        }

    }
}
