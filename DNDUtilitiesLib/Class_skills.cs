using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_skills : DBTable_bridge
    {

        const string TABLE = "class_skills";
        const string LIST_TABLE = "skills";
        const string FIELD1 = "class_id";
        const string FIELD2 = "skill_id";
        public int class_id
        {
            get;
            private set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Class_skills()
        {
            class_id = -1;
            skill_id = -1;
        }

        /// <summary>
        /// Constructor to assign values to fields
        /// </summary>
        /// <param name="characterKey">Character key</param>
        /// <param name="featKey">Feat key</param>
        public Class_skills(int classKey, int skillKey)
        {
            class_id = classKey;
            skill_id = skillKey;
        }

        /// <summary>
        /// Gets all skills for the class
        /// </summary>
        /// <param name="key">the class key</param>
        /// <returns>List of name and keys for the skills</returns>
        public static List<NameKey> retrieveAllSkills(int key)
        {
            return retrieveAll(TABLE, LIST_TABLE, FIELD2, FIELD1, key);
        }

        /// <summary>
        /// Gets all skills for the class
        /// </summary>
        /// <param name="classKey">the class key</param>
        /// <param name="raceKey">the race key</param>
        /// <returns>List of name and keys for the skills</returns>
        public static List<SkillInfo> retrieveAllSkills(int classKey, int raceKey)
        {
            List<SkillInfo> l = new List<SkillInfo>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                String sql = "SELECT s.skill_id, s.name, sa.adjustment, s.subtype, s.key_ability_id, " +
                    "(SELECT name from abilities WHERE ability_id = key_ability_id) AS ability_name " +
                    "FROM skills s, skill_subtypes ss, skill_adjustments sa " +
                    "WHERE s.skill_id = ss.skill_id AND " +
                        "(sa.race_id = @id1 OR sa.class_id = @id2)";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", raceKey);
                command.Parameters.AddWithValue("id2", classKey);

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int key = read.GetInt32(0);
                        string name = read.GetString(1);
                        int adjustment = read.GetInt32(2);
                        string subtype = read.GetString(3);
                        int ability_id;
                        if (read[4].GetType() != typeof(DBNull))
                            ability_id = read.GetInt32(4);
                        else
                            ability_id = -1;
                        string ability = read[5].ToString();
                        SkillInfo si = new SkillInfo(key, name, adjustment, subtype, ability_id, ability);
                        l.Add(si);
                    }
                }
                conn.Close();
                return l;
            }
        }

        /// <summary>
        /// outputs object as a string
        /// </summary>
        /// <returns>String representing object</returns>
        public override string ToString()
        {
            return "class_id: " + class_id + " skill_id: " + skill_id;

        }

    }


}
