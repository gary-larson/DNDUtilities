using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_possesions
    /// </summary>
    public class Character_possessions : DBTable_bridge
    {
        //Declare constants
        const string TABLE = "character_possessions";
        const string LIST_TABLE = "equipments";
        const string FIELD1 = "character_id";
        const string FIELD2 = "equipment_id";

        // Setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public string equipmentName
        {
            get;
            set;
        }

        public int equipment_id
        {
            get;
            private set;
        }

        public int quantity
        {
            get;
            set;
        }

        public string location
        {
            get;
            set;
        }

        public int magic_value
        {
            get;
            set;
        }

        public string special_properties
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Character_possessions()
        {
            character_id = -1;
            equipment_id = -1;
            equipmentName = null;
            quantity = 0;
            location = null;
            magic_value = 0;
            special_properties = null;
        }

        /// <summary>
        /// Constructor for all fields
        /// </summary>
        /// <param name="character_id">character key</param>
        /// <param name="equipmenty_id">equipment key</param>
        /// <param name="quantity">quantity</param>
        /// <param name="location">location</param>
        /// <param name="magic_value">magic value</param>
        /// /// <param name="special_properties">special propertiese</param>
        public Character_possessions(int character_id, int equipment_id, int quantity, string location, int magic_value, string special_properties)
        {
            this.character_id = character_id;
            this.equipment_id = equipment_id;
            equipmentName = null;
            this.quantity = quantity;
            this.location = location;
            this.magic_value = magic_value;
            this.special_properties = special_properties;
        }

        /// <summary>
        /// Get a record from appropriate tables
        /// </summary>
        /// <param name="characterKey">character key</param>
        /// <param name="equipmentkey">equipment key</param>
        /// <returns></returns>
        public Character_possessions retrieveRecord(int characterKey, int equipmentKey)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, equipment_id, (SELECT name FROM equipments WHERE equipment_id = @id1), quantity, location, magic_value, special_properties " +
                    "FROM character_possessions where character_id = @id2 AND equipment_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", equipmentKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", characterKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        character_id = read.GetInt32(0);
                        equipment_id = read.GetInt32(1);
                        equipmentName = read.GetString(2);
                        quantity = read.GetInt32(3);
                        location = read[4].ToString();
                        magic_value = read.GetInt32(5);
                        special_properties = read[6].ToString();
                    }
                    return this;
                }
            }
        }

        /// <summary>
        /// Gets all possesions for the character (returns only the name)
        /// use retrieveRecord to get more information
        /// </summary>
        /// <param name="key">the character key</param>
        /// <returns>List of name and keys for the possesions</returns>
        public static List<NameKey> retrieveAllPossesions(int key)
        {
            return retrieveAll(TABLE, LIST_TABLE, FIELD2, FIELD1, key);
        }

        /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        /// <param name="characterKey">character key if included it is used else uses character_id</param>
        /// <param name=possessionKey">possession key if included it is used else uses possession_id</param>
        public void save(int characterKey = -1, int possessionKey = -1)
        {
            String sql;

            if (characterKey > 0)
            {
                character_id = characterKey;
            }
            if (possessionKey > 0)
            {
                equipment_id = possessionKey;
            }
            if (!keyExists(TABLE, FIELD1, FIELD2, character_id, equipment_id))
            {
                sql = "INSERT INTO character_possesions (character_id, equipment_id, quantity, location, magic_value, special_properties)" +
                    " VALUES (@id1, @id2, @id3, @id4, @id5, @id6)";
            }
            else
            {
                sql = "UPDATE character_possesions SET quantity = @id3, location = @id4, magic_value = @id5, special_properties = @id6" +
                    " WHERE character_id = @id1 AND equipment_id = @id2";
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
                command.Parameters.AddWithValue("id2", this.equipment_id);
                command.Parameters.AddWithValue("id3", this.quantity);
                command.Parameters.AddWithValue("id4", this.location);
                command.Parameters.AddWithValue("id5", this.magic_value);
                command.Parameters.AddWithValue("id6", this.special_properties);

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
            return "Equipment: " + equipmentName + " Quantity: " + quantity + " Location: " + location + " Magic value: " + 
                magic_value + " Special properties: " + special_properties;
        }
    }
}
