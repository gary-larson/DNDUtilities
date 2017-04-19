using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_skills
    /// </summary>
    public class Character_skills : DBTable_bridge
    {
        // Declare constants
        const string TABLE = "character_skills";
        const string LIST_TABLE = "skills"; 
        const string FIELD1 = "character_id";
        const string FIELD2 = "skill_id";

        // Setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        public string skillName
        {
            get;
            set;
        }

        public int skill_rank
        {
            get;
            set;
        }

        public int skill_modifier
        {
            get;
            set;
        }

        public int ability_modifier
        {
            get;
            set;
        }

        public int misc_modifier
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Character_skills()
        {
            character_id = -1;
            skill_id = -1;
            skill_rank = 0;
            skill_modifier = 0;
            ability_modifier = 0;
            misc_modifier = 0;
        }

        /// <summary>
        /// Constructor for all fields
        /// </summary>
        /// <param name="character_id">character key</param>
        /// <param name="skill_id">skill key</param>
        /// /// <param name="skill_rank">skill rank</param>
        /// <param name="skill_modifier">skill modifier</param>
        /// <param name="ability_modifier">ability modifier</param>
        /// <param name="misc_modifier">misc modifier</param>
        public Character_skills(int character_id, int skill_id, int skill_rank, int skill_modifier, int ability_modifier, int misc_modifier)
        {
            this.character_id = character_id;
            this.skill_id = skill_id;
            skillName = null;
            this.skill_rank = skill_rank;
            this.skill_modifier = skill_modifier;
            this.ability_modifier = ability_modifier;
            this.misc_modifier = misc_modifier;
        }

        /// <summary>
        /// Get a record from appropriate tables
        /// </summary>
        /// <param name="characterKey">character key</param>
        /// <param name="skillkey">skill key</param>
        /// <returns></returns>
        public Character_skills retrieveRecord(int characterKey, int skillKey)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, skill_id, (SELECT name FROM skills WHERE skill_id = @id1), skill_rank, skill_modifier, ability_modifier, misc_modifier " +
                    "FROM character_skills WHERE character_id = @id2 AND skill_id = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", skillKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", characterKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        character_id = read.GetInt32(0);
                        skill_id = read.GetInt32(1);
                        skillName = read.GetString(2);
                        skill_rank = read.GetInt32(3);
                        skill_modifier = read.GetInt32(4);
                        ability_modifier = read.GetInt32(5);
                        misc_modifier = read.GetInt32(6);
                        
                    }
                    return this;
                }
            }
        }

        /// <summary>
        /// Gets all skills for the character (returns only the name)
        /// use retrieveRecord to get more information
        /// </summary>
        /// <param name="key">the character key</param>
        /// <returns>List of name and keys for the skills</returns>
        public static List<NameKey> retrieveAllSkills(int key)
        {
            return retrieveAll(TABLE, LIST_TABLE, FIELD2, FIELD1, key);
        }

        /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        /// <param name="characterKey">character key if included it is used else uses character_id</param>
        /// <param name=skillKey">skill key if included it is used else uses skill_id</param>
        public void save(int characterKey = -1, int skillKey = -1)
        {
            String sql;

            if (characterKey > 0)
            {
                character_id = characterKey;
            }
            if (skillKey > 0)
            {
                skill_id = skillKey;
            }
            if (!keyExists(TABLE, FIELD1, FIELD2, character_id, skill_id))
            {
                sql = "INSERT INTO character_skills (character_id, skill_id, skill_rank, skill_modifier, ability_modifier, misc_modifier)" +
                    " VALUES (@id1, @id2, @id3, @id4, @id5, @id6)";
            }
            else
            {
                sql = "UPDATE character_skills SET skill_rank = @id3, skill_modifier = @id4, ability_modifier = @id5, misc_modifier = @id6" +
                    " WHERE character_id = @id1 AND skill_id = @id2";
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

                command.Parameters.AddWithValue("id1", character_id);
                command.Parameters.AddWithValue("id2", skill_id);
                command.Parameters.AddWithValue("id3", skill_rank);
                command.Parameters.AddWithValue("id4", skill_modifier);
                command.Parameters.AddWithValue("id5", ability_modifier);
                command.Parameters.AddWithValue("id6", misc_modifier);

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
            return "Skill: " + skillName + " Skill Rank: " + skill_rank + " Skill modifier: " + skill_modifier + " Ability Modifier: " + ability_modifier + " Misc modifier: " + misc_modifier;
        } 
    }
}
