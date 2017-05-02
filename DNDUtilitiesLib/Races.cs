using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Races : DBTable
    {
        const string TABLE = "races";
        const string FIELD = "race_id";
        public int race_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public string size_name
        {
            get;
            set;
        }

        public int size_id
        {
            get;
            private set;
        }

        public int speed
        {
            get;
            set;
        }

        public int extra_feat
        {
            get;
            set;
        }

        public int extra_skill_points
        {
            get;
            set;
        }

        public string speed_condition
        {
            get;
            set;
        }

        public bool dark_vision
        {
            get;
            set;
        }

        public bool low_light_vision
        {
            get;
            set;
        }

        public bool stone_cunning
        {
            get;
            set;
        }

        public string spell_like_ability
        {
            get;
            set;
        }

        /// <summary>
        /// Retrieve record from database
        /// </summary>
        /// <param name="raceKey">To determine record to get</param>
        public void retrieveRecord(int raceKey)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT race_id, name, size_id, (SELECT name FROM sizes WHERE size_id = races.size_id) AS size, " + 
                    "speed, extra_feat, Extra_skill_points, speed_condition, dark_vision, low_light_vision, stone_cunning, spell_like_ability " +
                    "FROM races WHERE race_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", raceKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        race_id = read.GetInt32(0);
                        name = read.GetString(1);
                        size_id = read.GetInt32(2);
                        size_name = read.GetString(3);
                        speed = read.GetInt32(4);
                        extra_feat = read.GetInt32(5);
                        extra_skill_points = read.GetInt32(6);
                        speed_condition = read[7].ToString();
                        dark_vision = false;
                        String s = read[8].ToString();
                        if (s.Equals("Yes")){
                            dark_vision = true;
                        }
                        low_light_vision = false;
                        s = read[9].ToString();
                        if (s.Equals("Yes"))
                        {
                            low_light_vision = true;
                        }
                        stone_cunning = false;
                        s = read[10].ToString();
                        if (s.Equals("Yes"))
                        {
                            stone_cunning = true;
                        }
                        spell_like_ability = read[11].ToString();
                    }
                    else
                    {
                        race_id = -1;
                        name = null;
                        size_id = -1;
                        size_name = null;
                        speed = 0;
                        extra_feat = 0;
                        extra_skill_points = 0;
                        speed_condition = null;
                        dark_vision = false;
                        low_light_vision = false;
                        stone_cunning = false;
                        spell_like_ability = null;
                    }
                }
                conn.Close();
            }
        }


        public static List<NameKey> retrieveAllRaces()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public override string ToString()
        {
            return "name: = " + name;
        }
    }
}
