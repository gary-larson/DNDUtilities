using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_hit_points
    /// </summary>
    public class Character_hit_points : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "character_hit_points";
        const string FIELD = "character_id";

        // Setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public int level
        {
            get;
            private set;
        }

        public int amount
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Character_hit_points ()
        {
            character_id = -1;
            level = 0;
            amount = 0;
        }

        /// <summary>
        /// Constructor with character key
        /// </summary>
        /// <param name="key">character key</param>
        public Character_hit_points (int key)
        {
            character_id = key;
            level = 0;
            amount = 0;
        }

        /// <summary>
        /// constructor with all fields
        /// </summary>
        /// <param name="key">character key</param>
        /// <param name="level">level</param>
        /// <param name="amount">amount</param>
        public Character_hit_points (int key, int level, int amount)
        {
            character_id = key;
            this.level = level;
            this.amount = amount;
        }

        /// <summary>
        /// Gets total hit points for a character
        /// </summary>
        /// <param name="characterKey"> the character to get the hit points for</param>
        /// <returns>hit points or 0 if no entries</returns>
        public static int GetTotalHitPoints(int characterKey)
        {
            string sql;

            sql = "SELECT SUM(amount) FROM character_hit_points WHERE(character_id = @id1)";
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", characterKey);


                string s = command.ExecuteScalar().ToString();
                conn.Close();
                if (s == null || s.Length == 0)
                    return 0;
                else
                    return Int32.Parse(s);   
            }
        }

        /// <summary>
        /// Gets record indicated by primary key
        /// </summary>
        /// <param name="characterKey">part of primary key</param>
        /// <param name="level">part of primary key</param>
        /// <returns>Object with record</returns>
        public Character_hit_points retrieveRecord(int characterKey, int level)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, level, amount FROM character_hit_points " +
                    "WHERE character_id = @id1 AND level = @id2";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", characterKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", level.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        character_id = read.GetInt32(0);
                        this.level = read.GetInt32(1);
                        amount = read.GetInt32(2);
                    }
                    else
                    {
                        character_id = -1;
                        level = -1;
                        amount = 0;
                    }
                }
                conn.Close();
                return this;
            }
        }

        /// <summary>
        /// Deletes a record from character_hit_points
        /// </summary>
        public static bool delete(int characterKey, int levelKey)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "DELETE FROM character_hit_points where character_id = @id1 AND level = @id2";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", characterKey);
                command.Parameters.AddWithValue("id2", levelKey);

                int i = command.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        public bool save()
        {
            String sql;
            int i;

            if (!keyExists(TABLE, FIELD, "level", character_id, level))
            {
                sql = "INSERT INTO character_hit_points (character_id, level, amount)" +
                    " VALUES (@id1, @id2, @id3)";
            }
            else
            {
                sql = "UPDATE character_hit_points SET amount = @id3" +
                    " WHERE character_id = @id1 AND level = @id2";
            }
            i = runSqlite(sql, character_id, level, amount);
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Helper method to process Sql command
        /// </summary>
        /// <param name="sql">Sql command to process</param>
        /// <returns>number of records affected</returns>
        private static int runSqlite(String sql, int character_id, int level, int amount)
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
                command.Parameters.AddWithValue("id2", level);
                command.Parameters.AddWithValue("id3", amount);


                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }
        
        /// <summary>
        /// gets string representation of class
        /// </summary>
        /// <returns>string representation of class</returns>
        public override string ToString()
        {
            return "character_id: " + character_id + " level: " + level + " Amount: " + amount;
        } 

    }
}
