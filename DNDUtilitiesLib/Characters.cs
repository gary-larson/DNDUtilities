using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Characters : DBTable
    {
        const string TABLE = "characters";
        const string FIELD = "character_id";

        private int character_id
        {
            get;
            set;
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

        public void save()
        {
            String sql;
            int i1 = this.character_id, i2 = this.number_of_classes, 
                i3 = this.race_id, i4 = this.alignment_id, i5 = this.age, i7 = this.weight, 
                i6 = this.height, i8 = this.deleted;
            string s1 = this.name, s2 = this.player_name, s3 = this.race, s4 = this.alignment,
                s5 = this.deity, s6 = this.gender, s7 = this.eyes, s8 = this.hair, s9 = this.skin,
                s10 = this.description;
            using (SQLiteConnection conn = new SQLiteConnection())
            {


                retrieveRecord(character_id);
                int i;  // Changed position this was declared so that the iffstatement below stopped returning an error
                        // Val, 08-apr-2017
                if (this.character_id == -1)
                {
                    sql = "INSERT INTO characters (name, player_name, number_of_classes, " +
                    "race_id, alignment_id, deity, age, gender, height, weight, eyes, hair, skin, description, deleted)" +
                        " VALUES (@id1, @id2, @id3, @id4, @id5, @id6, @id7, @id8, @id9, @id10, @id11, @id12, @id13, @id14, @id15)";
                    i = runSqlite(sql, s1, s2, i2, i3, i4, s5, i5, s6, i6, i7, s7, s8, s9, s10, 0);
                }
                else
                {
                    sql = "UPDATE characters SET name = @1d1, player_name = @1d2, " + 
                        "number_of_classes= @ id3, race_id = @id4, alignment_id = @id5, " +
                        "deity = @id6, age = @id7, gender = @id8, height = @id9, " + 
                        "weight = @id10, eyes = @1d11, hair = @id12, skin = @id13, " +
                        "description = @id14 WHERE character_id = @id15";
                    i = runSqlite(sql, s1, s2, i2, i3, i4, s5, i5, s6, i6, i7, s7, s8, s9, s10, i1);
                }
                
                if (i > 0)
                {
                    retrieveRecord(i1);
                }
            }
        }

        private int runSqlite(String sql, string s1, string s2, int i2, int i3, int i4, 
            string s5, int i5, string s6, int i6, int i7, string s7, string s8, string s9,
            string s10, int i8)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", s1);
                command.Parameters.AddWithValue("id2", s2);
                command.Parameters.AddWithValue("id3", i2);
                command.Parameters.AddWithValue("id4", i3);
                command.Parameters.AddWithValue("id5", i4);
                command.Parameters.AddWithValue("id6", s5);
                command.Parameters.AddWithValue("id7", i5);
                command.Parameters.AddWithValue("id8", s6);
                command.Parameters.AddWithValue("id9", i6);
                command.Parameters.AddWithValue("id10", i7);
                command.Parameters.AddWithValue("id11", s7);
                command.Parameters.AddWithValue("id12", s8);
                command.Parameters.AddWithValue("id13", s9);
                command.Parameters.AddWithValue("id14", s10);
                command.Parameters.AddWithValue("id15", i8);


                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        public void delete()
        {
            delete(TABLE, FIELD, character_id);
        }

        public override string ToString()
        {
            return "name: " + name + " Player: " + player_name;
        }
    }
}
