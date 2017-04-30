using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skill_subtypes : DBTable_lookup
    {
        public int subtype_id
        {
            get;
            private set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public static List<NameKey> retrieveAllSubskillsfor(int skillID)
        {
            List<NameKey> result = new List<NameKey>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "select subtype_id, name from skill_subtypes where skill_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", skillID));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        NameKey temp = new NameKey(read.GetInt32(0), read.GetString(1));
                        result.Add(temp);
                    }
                }
            }

            return result;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Skill_subtypes retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
