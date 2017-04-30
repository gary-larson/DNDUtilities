using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skill_adjustments : DBTable_bridge
    {
        public int skill_adjustment_id
        {
            get;
            private set;
        }

        public int skill_id
        {
            get;
            private set;
        }

        public virtual int adjustment
        {
            get;
            set;
        }

        public virtual string condition
        {
            get;
            set;
        }

        public int race_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
        }

        internal virtual string FIELD
        {
            get;
            set;
        }

        internal virtual string FIELD_LIST
        {
            get;
            set;
        }

        internal virtual string TABLE
        {
            get;
            set;
        }

        public virtual Skills Skills
        {
            get;
            set;
        }

        public virtual Classes Classes
        {
            get;
            set;
        }

        public virtual Races races
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }
        public static void getSkillAdjustmentsforRace(int raceID, out List<int>skillID, out List<int>modifiers)
        {
            skillID = new List<int>();
            modifiers = new List<int>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "select skill_id, adjustment from skill_adjustments where race_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", raceID));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        skillID.Add(read.GetInt32(0));
                        modifiers.Add(read.GetInt32(1));
                    }

                }
            }
        }
        public virtual Domains retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
