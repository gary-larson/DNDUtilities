using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Racial_ability_adjustment : DBTable_bridge
    {
        public int race_id
        {
            get;
            private set;
        }

        public int ability_id
        {
            get;
            private set;
        }

        public virtual int adjustment
        {
            get;
            set;
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

        public virtual Races races
        {
            get;
            set;
        }

        public virtual Abilities Abilities
        {
            get;
            set;
        }

        public static int modArrays(int raceID, out List<int> ModIDs, out List<int> ModVal)
        {
            int result = 0;
                // result = 0: no results
                // result < 0: something broke
                // result = 1: Values

            
            ModIDs = new List<int>();
            ModVal = new List<int>();
            

            // Run Query, set result. save to ModIds/ModVals
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                // SELECT ability_id, adjustment WHERE race_ID = raceID
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                string sql = "SELECT ability_id, adjustment FROM racial_ability_adjustments WHERE race_ID = @raceID";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("raceID", raceID.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ModIDs.Add(read.GetInt32(0));
                        ModVal.Add(read.GetInt32(1));
                        result = 1;
                    }
                }
                conn.Close();
            }
            // run Neg Query, set result. save to NegModIDs

            return result;
        }
        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
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
