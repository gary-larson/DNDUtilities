using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Classes : DBTable
    {
        
        public int class_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public int hit_die
        {
            get;
            set;
        }

        public int skill_points
        {
            get;
            set;
        }

        private string ability
        {
            get;
            set;
        }

        private string spell_type
        {
            get;
            set;
        }

        public string proficiencies
        {
            get;
            set;
        }

        public int epic_feat_base_level
        {
            get;
            set;
        }

        public int epic_feat_interval
        {
            get;
            set;
        }

        public string epic_feat_list
        {
            get;
            set;
        }

        public string epic_full_text
        {
            get;
            set;
        }

        public string req_race
        {
            get;
            set;
        }

        public string req_weapon_proficiency
        {
            get;
            set;
        }

        public int req_base_attack_bonus
        {
            get;
            set;
        }

        public string req_skill
        {
            get;
            set;
        }

        public string req_feat
        {
            get;
            set;
        }

        public string req_spells
        {
            get;
            set;
        }

        public string req_languages
        {
            get;
            set;
        }

        public string req_psionics
	    {
		    get;
		    set;
	    }

        public string req_epic_feat
        {
            get;
            set;
        }

        public string req_special
        {
            get;
            set;
        }

        public string spell_list_1
        {
            get;
            set;
        }

        public string spell_list_2
        {
            get;
            set;
        }

        public string spell_list_3
        {
            get;
            set;
        }

        public string spell_list_4
        {
            get;
            set;
        }

        public string spell_list_5
        {
            get;
            set;
        }

        public string full_text
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public Classes retrieveRecord(int key)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT class_id, name, hit_die, skill_points, " + 
                    "(SELECT name from abilities where abilities.ability_id = classes.ability_id), " + 
                    "(SELECT name from spell_types WHERE spell_types.type_id = classes.type_id) " +
                    "FROM classes where class_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        class_id = read.GetInt32(0);
                        name = read.GetString(1);
                        hit_die = read.GetInt32(2);
                        skill_points = read.GetInt32(3);
                        ability = read[4].ToString();
                        spell_type = read[5].ToString();
                    }
                    return this;
                }
            }
        }

        public static List<NameKey> retrieveAllClasses()
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT class_id, name " +
                    "FROM classes where type = 'base'";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                List<NameKey> ls = new List<NameKey>();
                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int id = read.GetInt32(0);
                        string name = read.GetString(1);
                        NameKey cn = new NameKey(id, name);
                        ls.Add(cn);
                    }
                    return ls;
                }
            }
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "name: " + name + "hit_die: " + hit_die + "skill_points: " +
                skill_points + " ability: " + ability + " spell_type: " +
                spell_type;
        }

    }
}
