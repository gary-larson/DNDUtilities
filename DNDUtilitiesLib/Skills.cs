using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skills : DBTable
    {
        public const string TABLE = "skills";
        public const string FIELD = "skill_id";
        public int skill_id
        {
            get;
            private set;
        }

        public string name
        {
            get;
            set;
        }

        public int key_ability_id
        {
            get;
            private set;
        }
        public string has_subtype
        {
            get;
            private set;
        }
        public string trained
        {
            get;
            set;
        }

        public string armor_checked
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public string spell_check
        {
            get;
            set;
        }

        public string action
        {
            get;
            set;
        }

        public string try_again
        {
            get;
            set;
        }

        public string special
        {
            get;
            set;
        }

        public string retriction
        {
            get;
            set;
        }

        public string synergy
        {
            get;
            set;
        }

        public string epic_use
        {
            get;
            set;
        }

        public string untrained
        {
            get;
            set;
        }

        public virtual string psionic
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        public virtual IEnumerable<Skill_subtypes> skill_subtypes
        {
            get;
            set;
        }

        public void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public static Skills retrieve(int Key)
        {
            Skills output = new Skills();
            // retrieves all records of a Skill, and presents them as a Skill item.
                // Name, subtype, key_ability_id, the rest can be IGNORED on this page
            // i think this counts as something we needed but ill work on implementing it. 
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                string sql = "SELECT name, subtype, key_ability_id FROM skills WHERE skill_ID = @skillID";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("skillID", Key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    int temp_key_ability_id = -1;
                    while (read.Read())
                    {
                        string temp_name = read.GetString(0);
                        string temp_subtype = read.GetString(1);
                        try
                        {
                            temp_key_ability_id = read.GetInt32(2);
                        }
                        catch ( Exception e)
                        {
                            temp_key_ability_id = -1;
                        }
                        output.name = temp_name;
                        output.has_subtype = temp_subtype;
                        output.key_ability_id = temp_key_ability_id;
                    }
                }
                conn.Close();
            }
            return output;
        }

        /// <summary>
        /// Get all skills names
        /// </summary>
        /// <returns>list of all skills names</returns>
        public static List<NameKey> retrieveAllSkills()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
