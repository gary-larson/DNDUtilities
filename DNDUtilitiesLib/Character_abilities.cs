using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_abilities
    /// </summary>
    public class Character_abilities : DBTable_bridge
    {
        // Declare constants
        const string TABLE = "character_abilities";
        const string FIELD1 = "character_id";
        const string FIELD2 = "ability_id";

        // Set up fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public string abilityName
        {
            get;
            set;
        }

        public int ability_id
        {
            get;
            private set;
        }

        public int modifier
        {
            get;
            set;
        }

        public int temp
        {
            get;
            set;
        }

        public int temp_modifier
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Character_abilities()
        {
            character_id = -1;
            ability_id = -1;
            abilityName = null;
            modifier = 0;
            temp = 0;
            temp_modifier = 0;
        }

        /// <summary>
        /// Constructor for all fields
        /// </summary>
        /// <param name="character_id">character key</param>
        /// <param name="ability_id">ability key</param>
        /// <param name="modifier">modifier</param>
        /// <param name="temp">temp value</param>
        /// <param name="temp_modifier">temp modifier</param>
        public Character_abilities(int character_id, int ability_id, int modifier, int temp, int temp_modifier)
        {
            this.character_id = character_id;
            this.ability_id = ability_id;
            abilityName = null;
            this.modifier = modifier;
            this.temp = temp;
            this.temp_modifier = temp_modifier;
        }

        /// <summary>
        /// Get a record from appropriate tables
        /// </summary>
        /// <param name="characterKey">character key</param>
        /// <param name="abilitykey">ability key</param>
        /// <returns></returns>
        public Character_abilities retrieveRecord(int characterKey, int abilityKey)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, ability_id, (SELECT name FROM abilities WHERE ability_id = @id1), modifier, temp, temp_modifier " +
                    "FROM character_abilities " +
                    "WHERE character_id = @id2 AND ability_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", abilityKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", characterKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        character_id = read.GetInt32(0);
                        ability_id = read.GetInt32(1);
                        abilityName = read.GetString(2);
                        modifier = read.GetInt32(3);
                        temp = read.GetInt32(4);
                        temp_modifier = read.GetInt32(5);
                        
                    }
                    return this;
                }
            }
        }

        /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        /// <param name="characterKey">character key if included it is used else uses character_id</param>
        /// <param name=abilityKey">ability key if included it is used else uses ability_id</param>
        public void save(int characterKey = -1, int abilityKey = -1)
        {
            String sql;

            if (characterKey > 0)
            {
                character_id = characterKey;
            } 
            if (abilityKey > 0)
            {
                ability_id = abilityKey;
            }
            if (!keyExists(TABLE, FIELD1, FIELD2, character_id, ability_id))
            {
                sql = "INSERT INTO character_abilities (character_id, ability_id, modifier, temp, temp_modifier)" +
                    " VALUES (@id1, @id2, @id3, @id4, @id5)";
            }
            else
            {
                sql = "UPDATE character_abilities SET modifier = @id3, temp = @id4, temp_modifier = @id5" +
                    " WHERE character_id = @id1 AND ability_id = @id2";
            }
            int i = runSqlite(sql);
            
        }

        /// <summary>
        /// Helper method to process Sql command
        /// </summary>
        /// <param name="sql">Sql command to process</param>
        /// <returns>number of records affected</returns>
        private int runSqlite(String sql)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", this.character_id);
                command.Parameters.AddWithValue("id2", this.ability_id);
                command.Parameters.AddWithValue("id3", this.modifier);
                command.Parameters.AddWithValue("id4", this.temp);
                command.Parameters.AddWithValue("id5", this.temp_modifier);

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
            return "Ability: " + abilityName + " Modifier: " + modifier + " Temp: " + temp + " Temp modifier: " + temp_modifier;
        }
    }
}
