using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_wounds
    /// </summary>
    public class Character_wounds : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "character_wounds";
        const string FIELD = "wound_id";

        // Setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public int wound_id
        {
            get;
            private set;
        }

        public int amount
        {
            get;
            set;
        }

        public bool lethal
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Character_wounds()
        {
            wound_id = -1;
            character_id = -1;
            amount = 0;
            lethal = false;
        }

        /// <summary>
        /// Constructor with character key
        /// </summary>
        /// <param name="key">character key</param>
        public Character_wounds(int key)
        {
            wound_id = -1;
            character_id = key;
            amount = 0;
            lethal = false;
        }

        /// <summary>
        /// constructor with all fields
        /// </summary>
        /// <param name="woundKey">wound key</param>
        /// <param name="characterKey">character key</param>
        /// <param name="amount">amount</param>
        /// <param name="lethal">lethal</param>
        public Character_wounds(int woundKey, int characterKey, int amount, bool lethal)
        {
            wound_id = woundKey;
            character_id = characterKey;
            this.amount = amount;
            this.lethal = lethal;
        }

        /// <summary>
        /// Gets total wounds for a character
        /// </summary>
        /// <param name="characterKey"> the character to get the hit points for</param>
        /// <returns>wounds or 0 if no entries</returns>
        public static int GetTotalWounds(int characterKey)
        {
            string sql;

            sql = "SELECT SUM(amount) FROM character_wounds WHERE(character_id = @id1)";
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
        public void retrieveRecord(int woundKey)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT wound_id, character_id, lethal, amount FROM character_wounds " +
                    "WHERE wound_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", woundKey.ToString()));
                

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        wound_id = read.GetInt32(0);
                        character_id = read.GetInt32(1);
                        if (read.GetInt32(2) == 0)
                        {
                            lethal = false;
                        } else
                        {
                            lethal = true;
                        }
                        amount = read.GetInt32(3);
                    }
                    else
                    {
                        wound_id = -1;
                        character_id = -1;
                        lethal = false;
                        amount = 0;
                    }
                }
                conn.Close();
               // return this;
            }
        }

        public static List<Character_wounds> retrieveAllWounds(int characterKey)
        {
            List<Character_wounds> l = new List<Character_wounds>();

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT wound_id, character_id, amount, lethal FROM character_wounds " +
                    " WHERE character_id = @id1";

                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", characterKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        bool lethal = true;
                        int key1 = read.GetInt32(0);
                        int key2 = read.GetInt32(1);
                        int amount = read.GetInt32(2);
                        if (read.GetInt32(3) == 0)
                            lethal = false;
                        Character_wounds cw = new Character_wounds(key1, key2, amount, lethal);
                        l.Add(cw);
                    }
                }
                conn.Close();
                return l;
            }
        }


        /// <summary>
        /// Deletes a record from character_wounds
        /// </summary>
        public static bool delete(int woundKey)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "DELETE FROM character_wounds where wound_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", woundKey);
                

                int i = command.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Deletes all character's records record from character_wounds
        /// </summary>
        public static bool deleteAll(int characterKey)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "DELETE FROM character_wounds where character_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", characterKey);


                int i = command.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Deletes all records from character_wounds
        /// </summary>
        public static bool deleteAllRecords()
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "DELETE FROM character_wounds";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;


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
        public bool save(int wound_id = -1)
        {
            String sql;
            int i;
            bool isInsert;

            if (wound_id > 0)
                this.wound_id = wound_id;

            if (!keyExists(TABLE, FIELD, wound_id))
            {
                sql = "INSERT INTO character_wounds (character_id, amount, lethal)" +
                    " VALUES (@id1, @id2, @id3)";
                isInsert = true;
            }
            else
            {
                sql = "UPDATE character_wounds SET character_id = @id1, amount = @id2, lethal = @id3" +
                    " WHERE wound_id = @id4";
                isInsert = false;
            }
            i = runSqlite(isInsert, sql, wound_id, character_id, amount, lethal);
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
        private static int runSqlite(bool isInsert, String sql, int wound_id, int character_id, int amount, bool lethal)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                if (!isInsert)
                    command.Parameters.AddWithValue("id4", wound_id);
                command.Parameters.AddWithValue("id1", character_id);
                if (lethal)
                    command.Parameters.AddWithValue("id3", 1);
                else
                    command.Parameters.AddWithValue("id3", 0);
                command.Parameters.AddWithValue("id2", amount);


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
            return "Wound_id: " + wound_id + "character_id: " + character_id + " lethal: " + lethal + " Amount: " + amount;
        }
    }
}
