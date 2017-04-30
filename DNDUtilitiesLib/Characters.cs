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

        public int career_level
        {
            get;
            set;
        }

        public string race
        {
            get;
            set;
        }

        public int race_id
        {
            get;
            private set;
        }

        public string alignment
        {
            get;
            set;
        }

        public int alignment_id
        {
            get;
            private set;
        }

        public string deity
        {
            get;
            set;
        }

        public string size
        {
            get;
            set;
        }


        public int size_id
        {
            get;
            private set;
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

        public int speed
        {
            get;
            set;
        }

        public int experience_points
        {
            get;
            set;
        }

        public int money
        {
            get;
            set;
        }

        private int deleted
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
        public static List<NameKey> retrieveAll()
        {
            return retrieveAll(TABLE, FIELD);
        }

        /// <summary>
        /// Save record in database if does not exist Update existing record otherwise
        /// </summary>
        /// <returns>character_id is successful -1 otherwise</returns>
        public int save()
        {
            int i;
            int id;
            String sql;
            
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                // tests if record exists
                if (!keyExists(TABLE, FIELD, character_id))
                {
                    sql = "INSERT INTO characters (name, player_name, number_of_classes, career_level, " +
                    "race_id, alignment_id, deity, size_id, age, gender, height, weight, eyes, hair, skin, description, " +
                    "speed, experience_points, money, deleted)" +
                        " VALUES (@id1, @id2, @id3, @id4, " + 
                        "(SELECT race_id FROM races WHERE name = @id5), "+
                        "(SELECT alignment_id FROM alignments WHERE name = @id6), " +
                        "@id7, " + 
                        "(SELECT size_id FROM sizes WHERE name = @id8), " +
                        "@id9, @id10, @id11, @id12, @id13, @id14, @id15, @id16, @id17, @id18, @id19, 0);" + 
                        "SELECT character_id FROM characters WHERE name = @id1 AND player_name = @id2 AND deleted = 0";
                  
                    conn.ConnectionString = CONNECTION_STR;
                    conn.Open();
                    SQLiteCommand command = conn.CreateCommand();
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("id1", this.name);
                    command.Parameters.AddWithValue("id2", this.player_name);
                    command.Parameters.AddWithValue("id3", this.number_of_classes);
                    command.Parameters.AddWithValue("id4", this.career_level);
                    command.Parameters.AddWithValue("id5", this.race);
                    command.Parameters.AddWithValue("id6", this.alignment);
                    command.Parameters.AddWithValue("id7", this.deity);
                    command.Parameters.AddWithValue("id8", this.size);
                    command.Parameters.AddWithValue("id9", this.age);
                    command.Parameters.AddWithValue("id10", this.gender);
                    command.Parameters.AddWithValue("id11", this.height);
                    command.Parameters.AddWithValue("id12", this.weight);
                    command.Parameters.AddWithValue("id13", this.eyes);
                    command.Parameters.AddWithValue("id14", this.hair);
                    command.Parameters.AddWithValue("id15", this.skin);
                    command.Parameters.AddWithValue("id16", this.description);
                    command.Parameters.AddWithValue("id17", this.speed);
                    command.Parameters.AddWithValue("id18", this.experience_points);
                    command.Parameters.AddWithValue("id19", this.money);
           

                    id = Int32.Parse(command.ExecuteScalar().ToString());
                    conn.Close();
                    if (id > 0)
                        character_id = id;
                    else
                        id = -1;

                }
                else
                {
                    sql = "UPDATE characters SET name = @id1, player_name = @id2, number_of_classes = @id3, career_level = @id4, "+
                        "race_id = (SELECT race_id FROM races WHERE name = @id5), " +
                        "alignment_id = (SELECT alignment_id FROM alignments WHERE name = @id6), " +
                        "deity = @id7, " +
                        "size_id = (SELECT size_id FROM sizes WHERE name = @id8), " +
                        "age = @id9, gender = @id10, height = @id11, " + 
                        "weight = @id12, eyes = @id13, hair = @id14, skin = @id15, " +
                        "description = @id16, speed = @id17, experience_points = @id18, money = @id19 WHERE character_id = @id20";

                    conn.ConnectionString = CONNECTION_STR;
                    conn.Open();
                    SQLiteCommand command = conn.CreateCommand();
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("id1", this.name);
                    command.Parameters.AddWithValue("id2", this.player_name);
                    command.Parameters.AddWithValue("id3", this.number_of_classes);
                    command.Parameters.AddWithValue("id4", this.career_level);
                    command.Parameters.AddWithValue("id5", this.race);
                    command.Parameters.AddWithValue("id6", this.alignment);
                    command.Parameters.AddWithValue("id7", this.deity);
                    command.Parameters.AddWithValue("id8", this.size);
                    command.Parameters.AddWithValue("id9", this.age);
                    command.Parameters.AddWithValue("id10", this.gender);
                    command.Parameters.AddWithValue("id11", this.height);
                    command.Parameters.AddWithValue("id12", this.weight);
                    command.Parameters.AddWithValue("id13", this.eyes);
                    command.Parameters.AddWithValue("id14", this.hair);
                    command.Parameters.AddWithValue("id15", this.skin);
                    command.Parameters.AddWithValue("id16", this.description);
                    command.Parameters.AddWithValue("id17", this.speed);
                    command.Parameters.AddWithValue("id18", this.experience_points);
                    command.Parameters.AddWithValue("id19", this.money);
                    command.Parameters.AddWithValue("id20", this.character_id);

                    i = command.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                        id = character_id;
                    else
                        id = -1;
                }

                return id;
            }
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
