using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spell_level : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "spell_level";
        const string FIELD = "spell_level_id";

        // Declare fields with properties
        public int spell_level_id_id
        {
            get;
            private set;
        }

        public int spell_id
        {
            get;
            private set;
        }

        public int level
        {
            get;
            set;
        }

        public string classification
        {
            get;
            private set;
        }

  /*      /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        /// <param name="characterKey">character key if included it is used else uses character_id</param>
        /// <param name=abilityKey">ability key if included it is used else uses ability_id</param>
        public void save()
        {
            List<NameKey> l = new List<NameKey>();
            String sql;
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                sql = "SELECT spell_id, level FROM spells WHERE spell_id > 237";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int key = read.GetInt32(0);
                        string name = read.GetString(1);
                        NameKey nk = new NameKey(key, name);
                        l.Add(nk);
                    }
                }

                sql = "INSERT INTO spell_level (spell_id, level, classification)" +
                    " VALUES (@id1, @id2, @id3)";

                foreach (NameKey nk in l)
                {
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.Text;
                    String s = nk.name;
                    int index = 0, len = 0, x;
                    while (s.Length > index) {

                        len = s.IndexOf(" ", index) - index;
                        String classification = s.Substring(index, len);
                        index = index + len + 1;
                        String number = s.Substring(index, 1);
                        x = 0;

                        Int32.TryParse(number, out x);
                        index += 3;
                        if (classification.Equals("Sorcerer/Wizard"))
                        {
                            classification = "Sorcerer";
                            command.Parameters.AddWithValue("id1", nk.key);
                            command.Parameters.AddWithValue("id2", x);
                            command.Parameters.AddWithValue("id3", classification);

                            i = command.ExecuteNonQuery();
                            classification = "Wizard";
                            command.Parameters.AddWithValue("id1", nk.key);
                            command.Parameters.AddWithValue("id2", x);
                            command.Parameters.AddWithValue("id3", classification);

                            i = command.ExecuteNonQuery();
                        }
                        else
                        {
                            command.Parameters.AddWithValue("id1", nk.key);
                            command.Parameters.AddWithValue("id2", x);
                            command.Parameters.AddWithValue("id3", classification);


                            i = command.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();
            }

        } */

        
    }
}
