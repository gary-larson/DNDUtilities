using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table characters
    /// </summary>
    public class Characters : DBTable
    {
        //declare constants
        const string TABLE = "characters";
        const string FIELD = "character_id";

        //Setup fields with properties

        public int character_id
        {
            get;    // Edited to be Public, with a private Set, to allow for Character_ID to be pulled to construct other neccessary classes.
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public string player_name
        {
            get;
            set;
        }

        public int number_of_classes
        {
            get;
            set;
        }

        public string race
        {
            get;
            set;
        }

        private int race_id
        {
            get;
            set;
        }

        public string alignment
        {
            get;
            set;
        }

        private int alignment_id
        {
            get;
            set;
        }

        public string deity
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }

        public string gender
        {
            get;
            set;
        }

        public int height
        {
            get;
            set;
        }

        public int weight
        {
            get;
            set;
        }

        public string eyes
        {
            get;
            set;
        }

        public string hair
        {
            get;
            set;
        }

        public string skin
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public int deleted
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor to initialize member variables
        /// </summary>
        public Characters()
        {
            this.character_id = -1;
            this.name = null;
            this.player_name = null;
            this.number_of_classes = 0;
            this.race = null;
            this.race_id = -1;
            this.alignment = null;
            this.alignment_id = -1;
            this.deity = null;
            this.age = 0;
            this.gender = null;
            this.height = 0;
            this.weight = 0;
            this.eyes = null;
            this.hair = null;
            this.skin = null;
            this.description = null;
            this.deleted = 0;
        }

        /// <summary>
        /// Retrieve record from database
        /// </summary>
        /// <param name="characterKey">To determine record to get</param>
        /// <returns>this object populated from database if record exists</returns>
        public Characters retrieveRecord(int characterKey)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, name, player_name, number_of_classes, " +
                    "(SELECT name FROM races WHERE characters.race_id = races.race_id), race_id, " +
                    "(SELECT name FROM alignments WHERE characters.alignment_id = alignments.alignment_id), alignment_id, " +
                    "deity, age, gender, height, weight, eyes, hair, skin, description, deleted " +
                    "FROM characters WHERE character_id = @id1 AND deleted = 0";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", characterKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        this.character_id = read.GetInt32(0);
                        this.name = read.GetString(1);
                        this.player_name = read.GetString(2);
                        this.number_of_classes = read.GetInt32(3);
                        this.race = read.GetString(4);
                        this.race_id = read.GetInt32(5);
                        this.alignment = read.GetString(6);
                        this.alignment_id = read.GetInt32(7);
                        this.deity = read[8].ToString();
                        this.age = read.GetInt32(9);
                        this.gender = read.GetString(10);
                        this.height = read.GetInt32(11);
                        this.weight = read.GetInt32(12);
                        this.eyes = read.GetString(13);
                        this.hair = read.GetString(14);
                        this.skin = read.GetString(15);
                        this.description = read.GetString(16);
                        this.deleted = read.GetInt32(17);
                    }
                    else
                    {
                        this.character_id = -1;
                        this.name = null;
                        this.player_name = null;
                        this.number_of_classes = 0;
                        this.race = null;
                        this.race_id = -1;
                        this.alignment = null;
                        this.alignment_id = -1;
                        this.deity = null;
                        this.age = 0;
                        this.gender = null;
                        this.height = 0;
                        this.weight = 0;
                        this.eyes = null;
                        this.hair = null;
                        this.skin = null;
                        this.description = null;
                        this.deleted = 0;
                    }
                }
                conn.Close();
                return this;
            }
        }

        /// <summary>
        /// Get all character names
        /// </summary>
        /// <returns>list of all names</returns>
        public List<NameKey> retrieveAll()
        {
            return retrieveAll(TABLE, FIELD);
        }

        /// <summary>
        /// Save record in database if does not exist Update existing record otherwise
        /// </summary>
        /// <returns>true if saved false otherwise</returns>
        public bool save()
        {
            int i;
            String sql;
            
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                // tests if record exists
                if (!keyExists(TABLE, FIELD, character_id))
                {
                    sql = "INSERT INTO characters (name, player_name, number_of_classes, " +
                    "race_id, alignment_id, deity, age, gender, height, weight, eyes, hair, skin, description, deleted)" +
                        " VALUES (@id1, @id2, @id3, @id4, @id5, @id6, @id7, @id8, @id9, @id10, @id11, @id12, @id13, @id14, @id15)";
                    i = runSqlite(sql, true);
                }
                else
                {
                    sql = "UPDATE characters SET name = @id1, player_name = @id2, " + 
                        "number_of_classes = @id3, race_id = @id4, alignment_id = @id5, " +
                        "deity = @id6, age = @id7, gender = @id8, height = @id9, " + 
                        "weight = @id10, eyes = @id11, hair = @id12, skin = @id13, " +
                        "description = @id14 WHERE character_id = @id15";
                    i = runSqlite(sql, false);
                }

                if (i > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Helper function to establish connection to database and run a non query
        /// </summary>
        /// <param name="sql">String with SQL statement</param>
        /// <returns>number of records affected</returns>
        private int runSqlite(String sql, bool isInsert)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", this.name);
                command.Parameters.AddWithValue("id2", this.player_name);
                command.Parameters.AddWithValue("id3", this.number_of_classes);

                command.Parameters.AddWithValue("id4", this.race_id);
                command.Parameters.AddWithValue("id5", this.alignment_id);
                command.Parameters.AddWithValue("id6", this.deity);
                command.Parameters.AddWithValue("id7", this.age);
                command.Parameters.AddWithValue("id8", this.gender);
                command.Parameters.AddWithValue("id9", this.height);
                command.Parameters.AddWithValue("id10", this.weight);
                command.Parameters.AddWithValue("id11", this.eyes);
                command.Parameters.AddWithValue("id12", this.hair);
                command.Parameters.AddWithValue("id13", this.skin);
                command.Parameters.AddWithValue("id14", this.description);
                if (isInsert)
                {
                    command.Parameters.AddWithValue("id15", this.deleted);
                }
                else
                {
                    command.Parameters.AddWithValue("id15", this.character_id);
                }


                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        /// <summary>
        /// Deletes the record represented by character_id
        /// </summary>
        public void delete()
        {
            delete(TABLE, FIELD, character_id);
        }


        // Gives string representation of this object
        public override string ToString()
        {
            return "name: " + name + " Player: " + player_name;
        }
    }
}
