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

        public virtual Classes classes
        {
            get;
            set;
        }

        public virtual Skills skills
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Class_skills retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public static List<int> getSkillsForClass(int Key)
        {
            List<int> result = new List<int>();

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                string sql = "SELECT skill_id FROM class_skills WHERE class_ID = @classID";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("classID", Key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        result.Add(read.GetInt32(0));
                    }
                }
                conn.Close();
            }
            return result;
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
