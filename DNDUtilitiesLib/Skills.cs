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

        public string psionic
        {
            get;
            set;
        }

        public string full_text
        {
            get;
            set;
        }

        /// <summary>
        /// Get all skills names
        /// </summary>
        /// <returns>list of all skills names</returns>
        public static List<NameKey> retrieveAllSkills()
        {
            return retrieveAll(TABLE, FIELD);
        }

        /*       /// <summary>
               /// Retrieve record from database
               /// </summary>
               /// <param name="skillKey">To determine record to get</param>
               /// <returns>this object populated from database if record exists</returns>
               public Characters retrieveRecord(int skillKey)
               {

                   using (SQLiteConnection conn = new SQLiteConnection())
                   {
                       conn.ConnectionString = CONNECTION_STR;
                       conn.Open();

                       String sql = "SELECT skill_id, name, subtype, key_ability_id, " +
                           "(SELECT name FROM abilities WHERE characters.race_id = races.race_id), race_id, " +
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
               } */

        public override string ToString()
        {
            return name;
        }

    }
}
